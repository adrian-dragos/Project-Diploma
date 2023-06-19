import { Component, EventEmitter, Output, inject } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { CarGear, StudentClient } from '@api/api:';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-gear-buttons',
	templateUrl: './gear-buttons.component.html',
	styleUrls: ['./gear-buttons.component.scss']
})
@UntilDestroy()
export class GearButtonsComponent {
	@Output() carGearOutput = new EventEmitter<CarGear>();

	manualGear = CarGear.Manual;
	automaticGear = CarGear.Automatic;
	gearTypeForm: FormGroup;
	gearTypeControl: FormControl;
	role: string;
	studentGear: CarGear;

	studentClient = inject(StudentClient);

	constructor(private formBuilder: FormBuilder) {}

	ngOnInit(): void {
		const selectedGear = CarGear.Manual;
		this.carGearOutput.emit(selectedGear);
		this.gearTypeControl = this.formBuilder.control(selectedGear);
		this.gearTypeForm = this.formBuilder.group({
			gearOption: this.gearTypeControl
		});

		this.role = localStorage.getItem('userRole');
		if (this.role === 'student') {
			const studentId = parseInt(localStorage.getItem('userId'), 10);
			this.studentClient
				.getStudentProfile(studentId)
				.pipe(untilDestroyed(this))
				.subscribe((student) => {
					this.studentGear = student.gear;
					this.carGearOutput.emit(this.studentGear);
					this.gearTypeControl = this.formBuilder.control(this.studentGear);
					this.gearTypeForm = this.formBuilder.group({
						gearOption: this.gearTypeControl
					});
				});
		}

		this.gearTypeForm.get('gearOption').valueChanges.subscribe((value) => {
			this.carGearOutput.emit(value);
		});
	}
}
