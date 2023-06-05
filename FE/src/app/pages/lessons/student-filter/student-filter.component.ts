import { Component, inject } from '@angular/core';
import { MatSelectChange } from '@angular/material/select';
import { InstructorClient, StudentClient, StudentShortProfileViewModel } from '@api/api:';
import { LessonsService } from '@app/services/lessons.service';
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

	studentClient = inject(StudentClient);
	instructorsClient = inject(InstructorClient);
	lessonsService = inject(LessonsService);

	ngOnInit(): void {
		const role = localStorage.getItem('userRole');
		switch (role) {
			case 'instructor':
				this.fetchStudentsForInstructor();
				break;
			case 'admin': {
				this.fetchStudentsAdmin();
			}
		}
	}

	fetchStudentsForInstructor(): void {
		const currentStudentId = parseInt(localStorage.getItem('instructorId'));
		this.instructorsClient
			.getStudentShortProfile(currentStudentId)
			.pipe(untilDestroyed(this))
			.subscribe((students) => {
				this.students = students;
			});
	}

	fetchStudentsAdmin(): void {
		this.studentClient
			.getStudentsShortProfile()
			.pipe(untilDestroyed(this))
			.subscribe((students) => {
				this.students = students;
			});
	}

	onSelectionChange(event: MatSelectChange): void {
		const selectedStudents = event.value.map((str) => parseInt(str, 10));
		this.lessonsService.setStudentFilter(selectedStudents);
	}

	clearSelectedItems(event: Event): void {
		event.stopPropagation();
		if (this.selectedValues.length === 0) {
			return;
		}
		this.lessonsService.setStatusFilter([]);
		this.selectedValues = [];
	}
}
