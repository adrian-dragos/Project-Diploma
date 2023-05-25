import { Component, inject } from '@angular/core';
import { CarGear, CarModelViewModel, InstructorClient, InstructorProfileViewModel } from '@api/api:';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { Subscription } from 'rxjs';

@Component({
	selector: 'app-booking-sidebar',
	templateUrl: './booking-sidebar.component.html',
	styleUrls: ['./booking-sidebar.component.scss']
})
@UntilDestroy()
export class BookingSidebarComponent {
	// fields
	gearType: CarGear;
	instructors: InstructorProfileViewModel[] = [];
	instructorSubscription: Subscription;
	today = new Date();

	// services
	instructorClient = inject(InstructorClient);

	handleGearTypeChange(gearType: number): void {
		this.gearType = gearType;
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

	handleCarFilterChange(carModels: CarModelViewModel[]): void {
		console.log(carModels);
	}
}
