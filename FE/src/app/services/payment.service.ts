import { Injectable } from '@angular/core';
import { GetStudentPaymentFilterViewModel, PaymentMethod } from '@api/api:';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable()
export class PaymentService {
	private paymentsFilter: GetStudentPaymentFilterViewModel;
	private filterSubject: BehaviorSubject<GetStudentPaymentFilterViewModel>;

	constructor() {
		this.paymentsFilter = {
			studentIds: [],
			paymentMethod: []
		};
		// const userRole = localStorage.getItem('userRole');
		// if (userRole === 'student') {
		// 	this.paymentsFilter.studentIds = [Number(localStorage.getItem('userId'))];
		// }
		this.filterSubject = new BehaviorSubject<GetStudentPaymentFilterViewModel>(this.paymentsFilter);
	}

	setRangeDate(startDate: Date | null, endDate: Date | null): void {
		this.paymentsFilter.startDate = startDate;
		this.paymentsFilter.endDate = endDate;
		this.filterSubject.next(this.paymentsFilter);
	}

	setPaymentMethod(method: PaymentMethod[] | null): void {
		this.paymentsFilter.paymentMethod = method;
		this.filterSubject.next(this.paymentsFilter);
	}

	setStudentFilter(studentIds: number[] | null): void {
		this.paymentsFilter.studentIds = studentIds;
		this.filterSubject.next(this.paymentsFilter);
	}

	getPaymentsFilter(): Observable<GetStudentPaymentFilterViewModel> {
		return this.filterSubject.asObservable();
	}

	refreshFilter(): void {
		return this.filterSubject.next(this.paymentsFilter);
	}
}
