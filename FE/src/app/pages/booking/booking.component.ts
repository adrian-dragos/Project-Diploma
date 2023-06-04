import { Component, OnInit, inject } from '@angular/core';
import { PaymentClient } from '@api/api:';
import { TooltipConstants } from '@app/constants/tooltip.constants';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { BehaviorSubject, concatMap } from 'rxjs';

@Component({
	selector: 'app-booking',
	templateUrl: './booking.component.html',
	styleUrls: ['./booking.component.scss']
})
@UntilDestroy()
export class BookingComponent implements OnInit {
	tooltipShowDelay = TooltipConstants.SHOW_DELAY;
	hasToPay = false;
	fetchPaymentSubject = new BehaviorSubject<void>(undefined);

	paymentClient = inject(PaymentClient);

	ngOnInit(): void {
		this.fetchPaymentSubject
			.pipe(
				concatMap(() => this.paymentClient.getSumToPay(1)),
				untilDestroyed(this)
			)
			.subscribe((sumToPay) => {
				this.hasToPay = sumToPay > 0;
			});
	}

	handleBookingEvent(): void {
		console.log('Booking event handled');
		this.fetchPaymentSubject.next();
	}
}
