import { Component, OnInit, inject } from '@angular/core';
import { PaymentClient } from '@api/api:';
import { TooltipConstants } from '@app/constants/tooltip.constants';
import { PaymentService } from '@app/services/payment.service';
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
	role: string;

	paymentClient = inject(PaymentClient);

	ngOnInit(): void {
		this.role = localStorage.getItem('userRole');
		this.fetchPaymentSubject
			.pipe(
				concatMap(() => this.paymentClient.getSumToPay(parseInt(localStorage.getItem('userId'), 10))),
				untilDestroyed(this)
			)
			.subscribe((sumToPay) => {
				this.hasToPay = sumToPay > 0;
			});
	}

	handleBookingEvent(): void {
		this.fetchPaymentSubject.next();
	}
}
