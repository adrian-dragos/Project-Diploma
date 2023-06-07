import { Injectable } from '@angular/core';
import { GetLessonsViewModel, LessonStatus } from '@api/api:';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable()
export class LessonsService {
	private lessonsFilter: GetLessonsViewModel;
	private filterSubject: BehaviorSubject<GetLessonsViewModel>;

	constructor() {
		this.lessonsFilter = {
			studentIds: [],
			instructorIds: [],
			lessonStatuses: [],
			startDate: null,
			endDate: null,
			page: undefined
		};
		const userRole = localStorage.getItem('userRole');
		if (userRole === 'student') {
			this.lessonsFilter.studentIds = [Number(localStorage.getItem('userId'))];
		}
		this.filterSubject = new BehaviorSubject<GetLessonsViewModel>(this.lessonsFilter);
	}

	setRangeDate(startDate: Date | null, endDate: Date | null): void {
		this.lessonsFilter.startDate = startDate;
		this.lessonsFilter.endDate = endDate;
		this.filterSubject.next(this.lessonsFilter);
	}

	setStatusFilter(lessonStatus: LessonStatus[] | null): void {
		this.lessonsFilter.lessonStatuses = lessonStatus;
		this.filterSubject.next(this.lessonsFilter);
	}

	setInstructorsFilter(instructorIds: number[] | null): void {
		this.lessonsFilter.instructorIds = instructorIds;
		this.filterSubject.next(this.lessonsFilter);
	}

	setStudentFilter(studentIds: number[] | null): void {
		this.lessonsFilter.studentIds = studentIds;
		this.filterSubject.next(this.lessonsFilter);
	}

	getLessonsFilter(): Observable<GetLessonsViewModel> {
		return this.filterSubject.asObservable();
	}
}
