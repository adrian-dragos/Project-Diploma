import { Component, EventEmitter, Input, OnInit, Output, SimpleChanges, inject } from '@angular/core';
import { MatSelectChange } from '@angular/material/select';
import { CarClient, CarGear, CarModelViewModel } from '@api/api:';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { BehaviorSubject } from 'rxjs';

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
	selectedValues: string[] = [];

	fetchCarModelsSubject: BehaviorSubject<void> = new BehaviorSubject<void>(undefined);

	carClient = inject(CarClient);

	ngOnInit(): void {
		this.fetchCarModelsSubject.next();
		this.initFetchCarModelsSubject();
	}

	ngOnChanges(changes: SimpleChanges): void {
		if (changes['carGear']) {
			this.selectedValues = [];
			this.fetchCarModelsSubject.next();
		}
	}

	initFetchCarModelsSubject(): void {
		this.fetchCarModelsSubject.pipe(untilDestroyed(this)).subscribe(() => {
			this.fetchCarModels();
		});
	}

	fetchCarModels(): void {
		this.carClient
			.getCarModels(this.carGear)
			.pipe(untilDestroyed(this))
			.subscribe((cars) => (this.cars = cars));
	}

	onSelectionChange(event: MatSelectChange): void {
		const splitArray = event.value.flatMap((str) => str.split(' '));
		let selectedCar: CarModelViewModel[] = [];
		for (let i = 0; i < splitArray.length; i += 2) {
			selectedCar.push({ manufacturer: splitArray[i], model: splitArray[i + 1] });
		}
		this.carFilterOutput.emit(selectedCar);
	}
}
