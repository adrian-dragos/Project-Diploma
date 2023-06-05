import { Component, inject } from '@angular/core';
import { MatSelectChange } from '@angular/material/select';
import { LessonStatus } from '@api/api:';
import { LessonsService } from '@app/services/lessons.service';

@Component({
	selector: 'app-status-filter',
	templateUrl: './status-filter.component.html',
	styleUrls: ['./status-filter.component.scss']
})
export class StatusFilterComponent {
	displayedStatuses: string[];
	selectedValues: DisplayedLessonStatus[] = [];

	lessonsService = inject(LessonsService);

	constructor() {
		this.getFilterOptions();
	}

	getFilterOptions(): void {
		const displayedStatusEnum = DisplayedLessonStatus;
		const keys = Object.keys(displayedStatusEnum);
		this.displayedStatuses = keys.slice(keys.length / 2);
	}

	onSelectionChange(event: MatSelectChange): void {
		const lessonStatus = event.value.map((value: string) => {
			switch (value) {
				case 'Completed':
					return LessonStatus.Completed;
				case 'Upcoming':
					return LessonStatus.BookedPaid;
				case 'Canceled':
					return LessonStatus.Canceled;
				default:
					return null;
			}
		});

		this.lessonsService.setStatusFilter(lessonStatus);
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

enum DisplayedLessonStatus {
	Completed,
	Upcoming,
	Canceled
}
