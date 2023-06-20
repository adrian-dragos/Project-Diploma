import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CarGear, StudentClient, UpdateStudentProfileViewModel, UsersClient } from '@api/api:';
import { SnackBarService } from '@app/services/snack-bar.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-add-new-profile',
	templateUrl: './add-new-profile.component.html',
	styleUrls: ['./add-new-profile.component.scss']
})
@UntilDestroy()
export class AddNewProfileComponent implements OnInit {
	profileForm: FormGroup;

	studentClient = inject(StudentClient);
	snackbarService = inject(SnackBarService);
	userClient = inject(UsersClient);

	constructor(private readonly fb: FormBuilder, private readonly router: Router) {}

	ngOnInit(): void {
		this.createForm();
		this.userClient
			.getUserDetails()
			.pipe(untilDestroyed(this))
			.subscribe((user) => {
				localStorage.setItem('userRole', user.role);
				localStorage.setItem('userId', user.id.toString());
				console.log(user);
			});
	}

	createForm(): void {
		this.profileForm = this.fb.group({
			firstName: ['', Validators.required],
			lastName: ['', Validators.required],
			phoneNumber: ['', Validators.required]
			// gear: ['', Validators.required]
		});
	}

	onSubmit(): void {
		if (!this.profileForm.valid) {
			return;
		}

		const studentId = parseInt(localStorage.getItem('userId'), 10);
		this.studentClient
			.getStudentProfile(studentId)
			.pipe(untilDestroyed(this))
			.subscribe((profile) => {
				const updateProfile: UpdateStudentProfileViewModel = {
					...profile,
					firstName: this.profileForm.value.firstName,
					lastName: this.profileForm.value.lastName,
					phoneNumber: this.profileForm.value.phoneNumber,
					carGear: CarGear.Manual
				};
				console.log(updateProfile);
				this.studentClient
					.updateStudentProfile(studentId, updateProfile)
					.pipe(untilDestroyed(this))
					.subscribe(
						() => {
							{
								this.snackbarService.openSuccessSnackBar('Profile updated!');
								this.router.navigate(['/app/booking']);
							}
						},
						() => {
							this.snackbarService.openErrorSnackBar('Profile update failed!');
						}
					);
			});
	}
}
