import { Component, inject } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { LessonsService } from '@app/services/lessons.service';

@Component({
	selector: 'app-date-filter',
	templateUrl: './date-filter.component.html',
	styleUrls: ['./date-filter.component.scss']
})
export class DateFilterComponent {
	range = new FormGroup({
		start: new FormControl<Date | null>(null),
		end: new FormControl<Date | null>(null)
	});

	lessonsService = inject(LessonsService);

	onEndDateChange(): void {
		const startDate = new Date(this.range.value.start);
		this.lessonsService.setStartDate(startDate);
		const endDate = new Date(this.range.value.end);
		this.lessonsService.setEndDate(endDate);
	}

	clearDatepicker(event: Event): void {
		event.stopPropagation();
		if (this.range.value.start === null && this.range.value.end === null) {
			return;
		}
		this.range.reset();
		this.lessonsService.setStartDate(null);
		this.lessonsService.setEndDate(null);
	}
}
