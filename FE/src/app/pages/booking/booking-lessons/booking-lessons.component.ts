import { Component, OnInit, inject } from '@angular/core';
import { CarGear, GetAvailableLessonsViewModel, LessonsClient } from '@api/api:';
import { BookingConstants } from '@app/constants/booking.constatns';
import { BookingService } from '@app/services/booking.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { concatMap, tap } from 'rxjs';

@Component({
	selector: 'app-booking-lessons',
	templateUrl: './booking-lessons.component.html',
	styleUrls: ['./booking-lessons.component.scss']
})
@UntilDestroy()
export class BookingLessonsComponent implements OnInit {
	selectedDate: Date;
	dueDate: Date;
	isLoading = true;
	lessons: GetAvailableLessonsViewModel[];

	bookingService = inject(BookingService);
	lessonClient = inject(LessonsClient);

	ngOnInit(): void {
		this.fetchFilteredInstructors();
	}

	fetchFilteredInstructors(): void {
		this.bookingService
			.getLessonsFilter()
			.pipe(
				tap((filter) => {
					this.isLoading = true;
					this.selectedDate = filter.startDate;
					this.dueDate = this.getDueDate(filter.startDate);
				}),
				concatMap((filter) => this.lessonClient.getAvailableLessons(filter)),
				untilDestroyed(this)
			)
			.subscribe((lessons) => {
				this.lessons = lessons;
				this.isLoading = false;
			});
	}

	onTodayButtonClick(): void {
		this.selectedDate = new Date();
		this.bookingService.setDate(this.selectedDate);
	}

	getDueDate(date: Date): Date {
		const dueDate = new Date(date);
		dueDate.setDate(dueDate.getDate() + BookingConstants.DAYS_DUE_DATE);
		return dueDate;
	}

	onBackwardButtonClick(): void {
		const selectedDate = new Date(this.selectedDate);
		selectedDate.setDate(selectedDate.getDate() - BookingConstants.DAYS_BACKWARD);
		this.bookingService.setDate(selectedDate);
	}

	onForwardButtonClick(): void {
		const selectedDate = new Date(this.selectedDate);
		selectedDate.setDate(selectedDate.getDate() + BookingConstants.DAYS_FORWARD);
		this.bookingService.setDate(selectedDate);
	}

	getGearTypeText(gearType: number): string {
		return CarGear[gearType];
	}
}
