import { Component, OnInit, inject } from '@angular/core';
import { CarGear, InstructorClient, InstructorProfileViewModel } from '@api/api:';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-booking-sidebar',
	templateUrl: './booking-sidebar.component.html',
	styleUrls: ['./booking-sidebar.component.scss']
})
@UntilDestroy()
export class BookingSidebarComponent implements OnInit {
	// fields
	instructors: InstructorProfileViewModel[] = [];
	manualGear = CarGear.Manual;
	today = new Date();
	gearType: CarGear = CarGear.Manual;

	// services
	instructorClient = inject(InstructorClient);

	ngOnInit(): void {
		this.instructorClient
			.getInstructors(1)
			.pipe(untilDestroyed(this))
			.subscribe((instructors) => {
				this.instructors = instructors;
			});
	}
}
