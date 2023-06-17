import { Component, inject } from '@angular/core';
import { MatSelectChange } from '@angular/material/select';
import { StudentClient, StudentShortProfileViewModel } from '@api/api:';
import { BookingService } from '@app/services/booking.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-student-selection',
	templateUrl: './student-selection.component.html',
	styleUrls: ['./student-selection.component.scss']
})
@UntilDestroy()
export class StudentSelectionComponent {
	selectedValues: string[] = [];
	students: StudentShortProfileViewModel[];

	studentClient = inject(StudentClient);
	bookingService = inject(BookingService);

	ngOnInit(): void {
		const role = localStorage.getItem('userRole');
		if (role === 'admin') {
			this.fetchStudents();
		}
	}

	fetchStudents(): void {
		this.studentClient
			.getStudentsShortProfile()
			.pipe(untilDestroyed(this))
			.subscribe((students) => {
				this.students = students;
			});
	}

	onSelectionChange(event: MatSelectChange): void {
		this.bookingService.setStudentId(event.value);
	}

	clearSelectedItems(event: Event): void {
		event.stopPropagation();
		if (this.selectedValues.length === 0) {
			return;
		}
		this.bookingService.setStudentId(null);
		this.selectedValues = null;
	}
}
