import { Component, inject } from '@angular/core';
import { MatSelectChange } from '@angular/material/select';
import { InstructorClient, InstructorShortProfileViewModel } from '@api/api:';
import { AddLessonService } from '@app/services/add-lesson.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-instructor-picker',
	templateUrl: './instructor-picker.component.html',
	styleUrls: ['./instructor-picker.component.scss']
})
@UntilDestroy()
export class InstructorPickerComponent {
	selectedInstructorId: string[] = [];
	instructors: InstructorShortProfileViewModel[];

	instructorsClient = inject(InstructorClient);
	addLessonService = inject(AddLessonService);

	ngOnInit(): void {
		this.fetchInstructors();
	}

	fetchInstructors(): void {
		this.instructorsClient
			.getInstructorsShortProfile()
			.pipe(untilDestroyed(this))
			.subscribe((instructors) => {
				this.instructors = instructors;
			});
	}

	onSelectionChange(event: MatSelectChange): void {
		this.addLessonService.setInstructorId(event.value);
	}

	clearSelectedItems(event: Event): void {
		event.stopPropagation();
		if (this.selectedInstructorId.length === 0) {
			return;
		}
		this.addLessonService.setInstructorId(null);
		this.selectedInstructorId = [];
	}
}
