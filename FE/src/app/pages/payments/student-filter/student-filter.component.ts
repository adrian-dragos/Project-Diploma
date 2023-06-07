import { Component, inject } from '@angular/core';
import { MatSelectChange } from '@angular/material/select';
import { PaymentClient, StudentShortProfileViewModel } from '@api/api:';
import { PaymentService } from '@app/services/payment.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-student-filter',
	templateUrl: './student-filter.component.html',
	styleUrls: ['./student-filter.component.scss']
})
@UntilDestroy()
export class StudentFilterComponent {
	selectedValues: string[] = [];
	students: StudentShortProfileViewModel[];

	paymentService = inject(PaymentService);
	paymentClient = inject(PaymentClient);

	ngOnInit(): void {
		const role = localStorage.getItem('userRole');
		if (role === 'admin') {
			this.fetchStudents();
		}
	}

	fetchStudents(): void {
		this.paymentClient
			.getStudentListPayment()
			.pipe(untilDestroyed(this))
			.subscribe((students) => {
				this.students = students;
			});
	}

	onSelectionChange(event: MatSelectChange): void {
		const selectedStudents = event.value.map((str) => parseInt(str, 10));
		this.paymentService.setStudentFilter(selectedStudents);
	}

	clearSelectedItems(event: Event): void {
		event.stopPropagation();
		if (this.selectedValues.length === 0) {
			return;
		}
		this.paymentService.setStudentFilter([]);
		this.selectedValues = [];
	}
}
