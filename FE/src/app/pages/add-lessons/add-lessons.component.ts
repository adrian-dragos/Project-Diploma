import { Component, OnInit, inject } from '@angular/core';
import { AddLessonViewModel, LessonsClient } from '@api/api:';
import { AddLessonService } from '@app/services/add-lesson.service';
import { SnackBarService } from '@app/services/snack-bar.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-add-lessons',
	templateUrl: './add-lessons.component.html',
	styleUrls: ['./add-lessons.component.scss']
})
@UntilDestroy()
export class AddLessonsComponent implements OnInit {
	addLessonService = inject(AddLessonService);
	lessonClient = inject(LessonsClient);
	snackBarService = inject(SnackBarService);
	selectedTime: any;
	selectedDate: any;
	instructorId: number;
	role: string;

	ngOnInit(): void {
		this.role = localStorage.getItem('userRole');
		this.addLessonService
			.getInstructorId()
			.pipe(untilDestroyed(this))
			.subscribe((instructorId) => {
				this.instructorId = instructorId;
			});
	}

	addLesson(): void {
		const [hourStr, minutesStr] = this.selectedTime.split(':');
		const hour = parseInt(hourStr, 10);
		const minutes = parseInt(minutesStr, 10);
		this.selectedDate.setHours(hour);
		this.selectedDate.setMinutes(minutes);

		if (this.role === 'instructor') {
			this.instructorId = parseInt(localStorage.getItem('userId'), 10);
		}

		const lesson: AddLessonViewModel = { instructorId: this.instructorId, lessonStartTime: this.selectedDate.toISOString() };
		this.lessonClient
			.addLesson(lesson)
			.pipe(untilDestroyed(this))
			.subscribe(
				() => this.snackBarService.openSuccessSnackBar('Successfully added lesson'),
				(error) => this.snackBarService.openErrorSnackBar(error.message)
			);
	}

	onSubmit(): void {
		if (this.isFormValid()) {
			this.addLesson();
		}
	}

	isFormValid(): any {
		if (this.role === 'instructor') {
			return this.selectedDate && this.selectedTime;
		}
		return this.selectedDate && this.selectedTime && this.instructorId;
	}
}
