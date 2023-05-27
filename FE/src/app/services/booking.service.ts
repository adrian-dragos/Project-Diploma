import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable()
export class BookingService {
	currentDate = new Date();
	today = new Date(this.currentDate.getFullYear(), this.currentDate.getMonth(), this.currentDate.getDate());
	private dateSubject: BehaviorSubject<Date> = new BehaviorSubject<Date>(this.today);
	data$ = this.dateSubject.asObservable();

	setData(data: Date): void {
		this.dateSubject.next(data);
	}
}
