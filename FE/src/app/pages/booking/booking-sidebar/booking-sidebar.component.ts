import { Component, Input, OnInit, inject } from '@angular/core';
import { CarGear, CarModelViewModel, GetInstructorsFilterViewModel, InstructorClient, InstructorProfileViewModel } from '@api/api:';
import { BookingService } from '@app/services/booking.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { Subscription } from 'rxjs';

@Component({
	selector: 'app-booking-sidebar',
	templateUrl: './booking-sidebar.component.html',
	styleUrls: ['./booking-sidebar.component.scss']
})
@UntilDestroy()
export class BookingSidebarComponent implements OnInit {
	// fields
	gearType: CarGear;
	carModels: CarModelViewModel[] = [];
	instructors: InstructorProfileViewModel[] = [];
	instructorSubscription: Subscription;
	selectedDate: Date;

	// services
	instructorClient = inject(InstructorClient);
	bookingService = inject(BookingService);

	ngOnInit(): void {
		this.bookingService.data$.pipe(untilDestroyed(this)).subscribe((date) => {
			this.selectedDate = date;
		});
	}

	onDateSelection(date: Date): void {
		this.bookingService.setData(date);
	}

	handleGearTypeChange(gearType: number): void {
		this.gearType = gearType;
		this.carModels = [];

		if (this.instructorSubscription) {
			this.instructorSubscription.unsubscribe();
		}
		const filter: GetInstructorsFilterViewModel = {
			carGear: this.gearType,
			cars: this.carModels
		};

		this.instructorSubscription = this.instructorClient
			.getInstructors(filter)
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
		this.carModels = carModels;
		const filter: GetInstructorsFilterViewModel = {
			carGear: this.gearType,
			cars: this.carModels
		};

		this.instructorSubscription = this.instructorClient
			.getInstructors(filter)
			.pipe(untilDestroyed(this))
			.subscribe((instructors) => {
				this.instructors = instructors;
			});
	}
}
