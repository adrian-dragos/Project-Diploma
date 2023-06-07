import { Component, OnInit, inject } from '@angular/core';
import { MatSelectChange } from '@angular/material/select';
import { InstructorClient, InstructorShortProfileViewModel, StudentClient } from '@api/api:';
import { LessonsService } from '@app/services/lessons.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-instructor-filter',
	templateUrl: './instructor-filter.component.html',
	styleUrls: ['./instructor-filter.component.scss']
})
@UntilDestroy()
export class InstructorFilterComponent implements OnInit {
	selectedValues: string[] = [];
	instructors: InstructorShortProfileViewModel[];

	studentClient = inject(StudentClient);
	instructorsClient = inject(InstructorClient);
	lessonsService = inject(LessonsService);

	ngOnInit(): void {
		const role = localStorage.getItem('userRole');
		switch (role) {
			case 'student':
				this.fetchInstructorsForStudent();
				break;
			case 'admin': {
				this.fetchInstructorsAdmin();
			}
		}
	}

	fetchInstructorsForStudent(): void {
		const currentStudentId = parseInt(localStorage.getItem('userId'));
		this.studentClient
			.getInstructors(currentStudentId)
			.pipe(untilDestroyed(this))
			.subscribe((instructors) => {
				this.instructors = instructors;
			});
	}

	fetchInstructorsAdmin(): void {
		this.instructorsClient
			.getInstructorsShortProfile()
			.pipe(untilDestroyed(this))
			.subscribe((instructors) => {
				this.instructors = instructors;
			});
	}

	onSelectionChange(event: MatSelectChange): void {
		const selectedInstructorIds = event.value.map((str) => parseInt(str, 10));
		this.lessonsService.setInstructorsFilter(selectedInstructorIds);
	}

	clearSelectedItems(event: Event): void {
		event.stopPropagation();
		if (this.selectedValues.length === 0) {
			return;
		}
		this.lessonsService.setInstructorsFilter([]);
		this.selectedValues = [];
	}
}
