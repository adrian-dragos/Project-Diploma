import { Component, EventEmitter, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { CarGear } from '@api/api:';

@Component({
	selector: 'app-gear-buttons',
	templateUrl: './gear-buttons.component.html',
	styleUrls: ['./gear-buttons.component.scss']
})
export class GearButtonsComponent {
	@Output() carGearOutput = new EventEmitter<CarGear>();

	manualGear = CarGear.Manual;
	automaticGear = CarGear.Automatic;
	gearTypeForm: FormGroup;
	gearTypeControl: FormControl;

	constructor(private formBuilder: FormBuilder) {}

	ngOnInit(): void {
		//TODO: get user gear type from database
		this.carGearOutput.emit(this.manualGear);
		this.gearTypeControl = this.formBuilder.control(this.manualGear);
		this.gearTypeForm = this.formBuilder.group({
			gearOption: this.gearTypeControl
		});

		this.gearTypeForm.get('gearOption').valueChanges.subscribe((value) => {
			this.carGearOutput.emit(value);
		});
	}
}
