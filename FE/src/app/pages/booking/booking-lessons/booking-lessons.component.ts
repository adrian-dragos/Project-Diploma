import { Component, OnInit, inject } from '@angular/core';
import { CarGear, GetAvailableLessonDetailsViewModel, GetAvailableLessonsViewModel, LessonStatus, LessonsClient } from '@api/api:';
import { BookingConstants } from '@app/constants/booking.constants';
import { BookingService } from '@app/services/booking.service';
import { DialogService } from '@app/services/dialog.service';
import { SnackBarService } from '@app/services/snack-bar.service';
import { CancelLessonDialogComponent } from '@app/shared/components/cancel-lesson-dialog/cancel-lesson-dialog.component';
import { LessonDetailsDialogComponent } from '@app/shared/components/lesson-details-dialog/lesson-details-dialog.component';
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
	lessonBookedNotPaidStatus = LessonStatus.BookedNotPaid;

	bookingService = inject(BookingService);
	lessonClient = inject(LessonsClient);
	snackBarService = inject(SnackBarService);

	constructor(private readonly dialogService: DialogService) {}

	ngOnInit(): void {
		this.fetchLessons();
	}

	fetchLessons(): void {
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
			.subscribe((lessons: GetAvailableLessonsViewModel[]) => {
				console.log(this.lessons);
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

	onSelectLesson(lessonDetails: GetAvailableLessonDetailsViewModel): void {
		switch (lessonDetails.status) {
			case LessonStatus.BookedNotPaid:
				this.shoWLessonDetails(lessonDetails);
				break;
			case LessonStatus.Unbooked:
				this.bookLessonRequest(lessonDetails.id, new Date(lessonDetails.startTime), new Date(lessonDetails.endTime));
				break;
		}
	}

	shoWLessonDetails(lesson: GetAvailableLessonDetailsViewModel): void {
		const dialogRef = this.dialogService.openDialog(LessonDetailsDialogComponent, {
			title: 'Dragos Adrian',
			content: lesson
		});

		dialogRef
			.afterClosed()
			.pipe(untilDestroyed(this))
			.subscribe((result) => {
				if (result) {
					this.unbookLessonRequest(lesson.id);
				}
			});
	}

	unbookLesson(lessonId: number, event: Event): void {
		event.stopPropagation();
		const dialogRef = this.dialogService.openDialog(CancelLessonDialogComponent, {
			title: 'Unbook lesson',
			message: 'Are you sure you want to unbook this lesson?'
		});

		dialogRef
			.afterClosed()
			.pipe(untilDestroyed(this))
			.subscribe((result) => {
				if (result) {
					this.unbookLessonRequest(lessonId);
				}
			});
	}

	bookLessonRequest(lessonId: number, startTime: Date, endTime: Date): void {
		this.lessonClient
			.bookLesson({
				lessonId: lessonId,
				studentId: 1
			})
			.pipe(untilDestroyed(this))
			.subscribe(
				() => {
					this.snackBarService.openSuccess('Lesson booked successfully');
					this.updateSelectedLessonStatus(lessonId, LessonStatus.BookedNotPaid);
				},
				() => {
					const startHour = startTime.getHours().toString().padStart(2, '0');
					const startMinutes = startTime.getMinutes().toString().padStart(2, '0');
					const endHour = endTime.getHours().toString().padStart(2, '0');
					const endMinutes = endTime.getMinutes().toString().padStart(2, '0');
					this.snackBarService.openError(
						`Please note that you already have a lesson scheduled from ${startHour}.${startMinutes} to ${endHour}.${endMinutes}!`
					);
				}
			);
	}

	unbookLessonRequest(lessonId: number): void {
		this.lessonClient
			.unbookLesson({
				lessonId: lessonId,
				studentId: 1
			})
			.pipe(untilDestroyed(this))
			.subscribe(
				() => {
					this.snackBarService.openSuccess('Lesson unbooked successfully');
					this.updateSelectedLessonStatus(lessonId, LessonStatus.Unbooked);
				},
				() => this.snackBarService.openError('Error while unbooking lesson')
			);
	}

	updateSelectedLessonStatus(lessonId: number, status: LessonStatus): void {
		for (const lesson of this.lessons) {
			for (const ld of lesson.lessonsDetails) {
				if (ld.id === lessonId) {
					ld.status = status;
					this.snackBarService.openSuccess('Lesson booked successfully');
					return;
				}
			}
		}
	}
}
