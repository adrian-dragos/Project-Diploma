import { Component, OnInit, inject } from '@angular/core';
import { CarGear, GetAvailableLessonsViewModel, LessonFilterViewModel, LessonsClient } from '@api/api:';
import { BookingConstants } from '@app/constants/booking.constatns';
import { BookingService } from '@app/services/booking.service';

@Component({
	selector: 'app-booking-lessons',
	templateUrl: './booking-lessons.component.html',
	styleUrls: ['./booking-lessons.component.scss']
})
export class BookingLessonsComponent implements OnInit {
	selectedDate: Date;
	dueDate: Date;
	lessons: GetAvailableLessonsViewModel[];

	bookingService = inject(BookingService);
	lessonClient = inject(LessonsClient);

	ngOnInit(): void {
		this.bookingService.data$.subscribe((date) => {
			console.log(date);
			this.selectedDate = date;
			this.dueDate = this.getDueDate(date);
			const filter: LessonFilterViewModel = {
				carGear: CarGear.Manual,
				carManufacturer: 'Dacia',
				carModel: 'Sandero',
				startDate: date,
				endDate: this.dueDate
			};
			console.log(filter);
			this.lessonClient.getAvailableLessons(filter).subscribe((lessons) => {
				console.log(lessons);
				this.lessons = lessons;
			});
		});
	}

	onTodayButtonClick(): void {
		this.selectedDate = new Date();
		this.bookingService.setData(this.selectedDate);
	}

	getDueDate(date: Date): Date {
		const dueDate = new Date(date);
		dueDate.setDate(dueDate.getDate() + BookingConstants.DAYS_DUE_DATE);
		return dueDate;
	}

	onBackwardButtonClick(): void {
		const selectedDate = new Date(this.selectedDate);
		selectedDate.setDate(selectedDate.getDate() - BookingConstants.DAYS_BACKWARD);
		this.bookingService.setData(selectedDate);
	}

	onForwardButtonClick(): void {
		const selectedDate = new Date(this.selectedDate);
		selectedDate.setDate(selectedDate.getDate() + BookingConstants.DAYS_FORWARD);
		this.bookingService.setData(selectedDate);
	}

	getGearTypeText(gearType: number): string {
		return CarGear[gearType];
	}
}
