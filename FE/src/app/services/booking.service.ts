import { Injectable } from '@angular/core';
import { CarGear, CarModelViewModel, LessonFilterViewModel } from '@api/api:';
import { BookingConstants } from '@app/constants/booking.constants';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable()
export class BookingService {
	currentDate = new Date();
	today = new Date(this.currentDate.getFullYear(), this.currentDate.getMonth(), this.currentDate.getDate());

	private dateSubject: BehaviorSubject<Date> = new BehaviorSubject<Date>(this.today);
	private lessonsFilter = {
		instructorId: null,
		carModels: [],
		carGear: CarGear.Manual,
		startDate: this.currentDate,
		endDate: this.getEndDate(this.currentDate)
	};

	private filterSubject: BehaviorSubject<LessonFilterViewModel> = new BehaviorSubject<LessonFilterViewModel>(this.lessonsFilter);

	setDate(startDate: Date): void {
		this.lessonsFilter.startDate = startDate;
		this.lessonsFilter.endDate = this.getEndDate(startDate);
		this.filterSubject.next(this.lessonsFilter);
		this.dateSubject.next(startDate);
	}

	setGearFilter(carGear: CarGear): void {
		this.lessonsFilter.instructorId = null;
		this.lessonsFilter.carModels = [];
		this.lessonsFilter.carGear = carGear;
		this.filterSubject.next(this.lessonsFilter);
	}

	setCarModelsFilter(carModels: CarModelViewModel[]): void {
		this.lessonsFilter.instructorId = null;
		this.lessonsFilter.carModels = carModels;
		this.filterSubject.next(this.lessonsFilter);
	}

	setInstructorFilter(instructorId: number | null): void {
		this.lessonsFilter.instructorId = instructorId;
		this.filterSubject.next(this.lessonsFilter);
	}
	getSelectedDate(): Observable<Date> {
		return this.dateSubject.asObservable();
	}

	getLessonsFilter(): Observable<LessonFilterViewModel> {
		return this.filterSubject.asObservable();
	}

	private getEndDate(date: Date): Date {
		const dueDate = new Date(date);
		dueDate.setDate(dueDate.getDate() + BookingConstants.DAYS_DUE_DATE);
		return dueDate;
	}
}
