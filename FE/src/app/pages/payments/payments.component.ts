import { Component, OnInit, inject } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { GetStudentPaymentFilterViewModel, GetStudentPaymentViewModel, PaymentClient, PaymentMethod } from '@api/api:';
import { TooltipConstants } from '@app/constants/tooltip.constants';
import { PaymentService } from '@app/services/payment.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { concatMap, tap } from 'rxjs';

@Component({
	selector: 'app-payments',
	templateUrl: './payments.component.html',
	styleUrls: ['./payments.component.scss']
})
@UntilDestroy()
export class PaymentsComponent implements OnInit {
	tooltipShowDelay = TooltipConstants.SHOW_DELAY;
	isLoading = true;
	dataSource: MatTableDataSource<GetStudentPaymentViewModel>;
	columns: string[] = ['date', 'sum', 'paymentMethod', 'addedBy'];
	hasToPay = false;
	sumToPay = 0;
	unpaid = PaymentMethod.Unpaid;
	cash = PaymentMethod.Cash;
	card = PaymentMethod.Card;

	paymentClient = inject(PaymentClient);
	paymentService = inject(PaymentService);

	ngOnInit(): void {
		this.paymentService
			.getPaymentsFilter()
			.pipe(
				tap(() => (this.isLoading = true)),
				concatMap((filter) => this.paymentClient.getStudentPayments(filter)),
				untilDestroyed(this)
			)
			.subscribe((data) => {
				this.dataSource = new MatTableDataSource(data);
				this.isLoading = false;
				this.hasToPay = data.some((payment) => payment.method === PaymentMethod.Unpaid);
			});

		this.paymentClient
			.getSumToPay(1)
			.pipe(untilDestroyed(this))
			.subscribe((sumToPay) => {
				this.sumToPay = sumToPay;
			});
	}

	getMethodText(paymentMethod: number): string {
		return PaymentMethod[paymentMethod];
	}
}
