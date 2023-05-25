import { Component, inject } from '@angular/core';
import { CarGear, InstructorClient, InstructorProfileViewModel } from '@api/api:';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { Observable, Subscription, take } from 'rxjs';

@Component({
	selector: 'app-booking-sidebar',
	templateUrl: './booking-sidebar.component.html',
	styleUrls: ['./booking-sidebar.component.scss']
})
@UntilDestroy()
export class BookingSidebarComponent {
	// fields
	instructors: InstructorProfileViewModel[] = [];
	instructorSubscription: Subscription;
	today = new Date();

	// services
	instructorClient = inject(InstructorClient);

	handleGearTypeChange(gearType: number): void {
		if (this.instructorSubscription) {
			this.instructorSubscription.unsubscribe();
		}

		this.instructorSubscription = this.instructorClient
			.getInstructors(gearType)
			.pipe(untilDestroyed(this))
			.subscribe((instructors) => {
				this.instructors = instructors;
			});
	}

	getGearTypeText(gearType: number): string {
		return CarGear[gearType];
	}
}
