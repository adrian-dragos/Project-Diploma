import { Component, OnInit, inject } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { GetStudentPaymentViewModel, PaymentClient, PaymentMethod } from '@api/api:';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { tap } from 'rxjs';

@Component({
	selector: 'app-payments',
	templateUrl: './payments.component.html',
	styleUrls: ['./payments.component.scss']
})
@UntilDestroy()
export class PaymentsComponent implements OnInit {
	isLoading = true;
	dataSource: MatTableDataSource<GetStudentPaymentViewModel>;
	columns: string[] = ['date', 'sum', 'paymentMethod', 'addedBy'];

	paymentClient = inject(PaymentClient);

	ngOnInit(): void {
		this.paymentClient
			.getStudentPayments(1)
			.pipe(
				tap(() => (this.isLoading = true)),
				untilDestroyed(this)
			)
			.subscribe((data) => {
				this.dataSource = new MatTableDataSource(data);
				this.isLoading = false;
			});
	}

	getMethodText(paymentMethod: number): string {
		return PaymentMethod[paymentMethod];
	}
}
