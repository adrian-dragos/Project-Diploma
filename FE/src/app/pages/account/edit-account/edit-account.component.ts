import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { CarGear, StudentClient, StudentProfileViewModel, UpdateStudentProfileViewModel } from '@api/api:';
import { SnackBarService } from '@app/services/snack-bar.service';
import { CancelDialogComponent } from '@app/shared/components/cancel-dialog/cancel-dialog.component';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { tap } from 'rxjs';

@Component({
	selector: 'app-edit-account',
	templateUrl: './edit-account.component.html',
	styleUrls: ['./edit-account.component.scss']
})
@UntilDestroy()
export class EditAccountComponent implements OnInit {
	myForm: FormGroup;
	manualGear = CarGear.Manual;
	automaticGear = CarGear.Automatic;
	gearEnum: CarGear[] = [CarGear.Manual, CarGear.Automatic];
	isLoading = false;

	constructor(private readonly formBuilder: FormBuilder, private readonly router: Router, private readonly dialog: MatDialog) {}

	studentClient = inject(StudentClient);
	snackBarService = inject(SnackBarService);

	ngOnInit(): void {
		this.buildForm();
		this.studentClient
			.getStudentProfile(1)
			.pipe(
				tap(() => (this.isLoading = true)),
				untilDestroyed(this)
			)
			.subscribe((student) => {
				this.buildForm(student);
				this.isLoading = false;
			});
	}

	getGearTypeText(gearType: any): string {
		return CarGear[gearType];
	}

	buildForm(student?: StudentProfileViewModel): void {
		this.myForm = this.formBuilder.group({
			phoneNumber: [student?.phoneNumber ?? '', Validators.required],
			email: [student?.email ?? '', [Validators.required, Validators.email]],
			gear: [student?.gear ?? '', Validators.required]
		});
	}

	submitForm(): void {
		if (!this.myForm.valid) {
			return;
		}
		const student: UpdateStudentProfileViewModel = {
			email: this.myForm.value.email,
			phoneNumber: this.myForm.value.phoneNumber,
			carGear: this.myForm.value.gear
		};
		console.log(student);

		this.studentClient
			.updateStudentProfile(1, student)
			.pipe(untilDestroyed(this))
			.subscribe(
				() => {
					this.snackBarService.openSuccess('Profile updated successfully');
					this.router.navigate(['/account']);
				},
				(error) => this.snackBarService.openWarning('Profile update failed')
			);
	}

	routeToAccount(): void {
		const dialogRef = this.dialog.open(CancelDialogComponent, {
			autoFocus: false
		});

		dialogRef
			.afterClosed()
			.pipe(untilDestroyed(this))
			.subscribe((result) => {
				if (result === true) {
					console.log(result);
					this.router.navigate(['/account']);
				}
			});
	}
}
