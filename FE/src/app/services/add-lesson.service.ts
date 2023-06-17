import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';

@Injectable()
export class AddLessonService {
	private instructorIdSubject: Subject<number> = new Subject<number>();

	setInstructorId(instructorId: number | null): void {
		this.instructorIdSubject.next(instructorId);
	}

	getInstructorId(): Observable<number> {
		return this.instructorIdSubject;
	}
}
