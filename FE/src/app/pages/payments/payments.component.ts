import { Component, OnInit, inject } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { GetStudentPaymentFilterViewModel, GetStudentPaymentViewModel, PaymentClient, PaymentMethod } from '@api/api:';
import { TooltipConstants } from '@app/constants/tooltip.constants';
import { PaymentService } from '@app/services/payment.service';
import { SnackBarService } from '@app/services/snack-bar.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { concatMap, delay, tap } from 'rxjs';

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
	columns: string[] = ['date', 'sum', 'paymentMethod', 'addedBy', 'actions'];
	hasToPay = false;
	sumToPay = 0;
	unpaid = PaymentMethod.Unpaid;
	cash = PaymentMethod.Cash;
	card = PaymentMethod.Card;
	userRole: string;

	paymentClient = inject(PaymentClient);
	paymentService = inject(PaymentService);
	snackBarService = inject(SnackBarService);

	ngOnInit(): void {
		this.userRole = localStorage.getItem('userRole');
		if (this.userRole === 'student') {
			const studentId = [parseInt(localStorage.getItem('userId'), 10)];
			this.paymentService.setStudentFilter(studentId);
		} else {
			this.paymentService.setStudentFilter([]);
		}
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
			.getSumToPay(parseInt(localStorage.getItem('userId'), 10))
			.pipe(untilDestroyed(this))
			.subscribe((sumToPay) => {
				this.sumToPay = sumToPay;
			});
	}

	getMethodText(paymentMethod: number): string {
		return PaymentMethod[paymentMethod];
	}

	payLesson(sum: number, studentId: number): void {
		this.paymentClient
			.pay({
				studentId: studentId,
				amount: sum,
				paymentMethod: PaymentMethod.Card
			})
			.pipe(
				tap(() => (this.isLoading = true)),
				delay(1000),
				untilDestroyed(this)
			)
			.subscribe(
				() => {
					this.snackBarService.openSuccessSnackBar('Payment successful');
					this.isLoading = false;
					this.paymentService.refreshFilter();
				},
				(error) => this.snackBarService.openErrorSnackBar(error.error.message)
			);
	}
}
