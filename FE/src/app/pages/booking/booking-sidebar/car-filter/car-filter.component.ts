import { Component, EventEmitter, Input, OnInit, Output, SimpleChanges, inject } from '@angular/core';
import { MatSelectChange } from '@angular/material/select';
import { CarClient, CarGear, CarModelViewModel } from '@api/api:';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-car-filter',
	templateUrl: './car-filter.component.html',
	styleUrls: ['./car-filter.component.scss']
})
@UntilDestroy()
export class CarFilterComponent implements OnInit {
	@Input() carGear: CarGear;
	@Output() carFilterOutput = new EventEmitter<CarModelViewModel[]>();

	cars: CarModelViewModel[] = [];

	carClient = inject(CarClient);

	ngOnInit(): void {
		this.carClient
			.getCarModels(this.carGear)
			.pipe(untilDestroyed(this))
			.subscribe((cars) => (this.cars = cars));
	}

	ngOnChanges(changes: SimpleChanges): void {
		if (changes['carGear']) {
			this.carClient
				.getCarModels(this.carGear)
				.pipe(untilDestroyed(this))
				.subscribe((cars) => (this.cars = cars));
		}
	}

	onSelectionChange(event: MatSelectChange): void {
		this.carFilterOutput.emit(event.value);
	}
}
