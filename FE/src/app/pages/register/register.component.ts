import { Component, inject } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ApiException, RegisterUserRequestViewModel, UsersClient } from '@app/api/api';
import { SnackBarService } from '@app/services/snack-bar.service';
import { CustomValidators } from '@app/validators/pattern.validator';
import { UserValidator } from '@app/validators/user.validator';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-register',
	templateUrl: './register.component.html',
	styleUrls: ['./register.component.scss']
})
@UntilDestroy()
export class RegisterComponent {
	snackBarService = inject(SnackBarService);
	userValidator = inject(UserValidator);

	hideRegisterPasswordIcon = true;
	hideConfirmPasswordIcon = true;
	registerPasswordIcon = 'visibility';
	confirmPasswordIcon = 'visibility';

	constructor(private readonly client: UsersClient, private readonly router: Router) {}

	emailControl = new FormControl('', [Validators.required, Validators.email], this.userValidator.checkUniqueEmail());
	passwordControl = new FormControl('', [
		Validators.required,
		Validators.minLength(8),
		CustomValidators.patternValidator(/\d/, { hasNumber: true }),
		CustomValidators.patternValidator(/[A-Z]/, { hasCapitalCase: true }),
		CustomValidators.patternValidator(/[a-z]/, { hasSmallCase: true })
	]);
	confirmPasswordControl = new FormControl('', [Validators.required]);

	registerForm = new FormGroup(
		{
			email: this.emailControl,
			password: this.passwordControl,
			confirmPassword: this.confirmPasswordControl
		},
		this.arePasswordEqualValidator
	);

	onSubmit(): void {
		if (this.registerForm.valid) {
			const email = this.emailControl.value;
			const password = this.passwordControl.value;

			const user: RegisterUserRequestViewModel = { email, password };

			this.client
				.registerUser(user)
				.pipe(untilDestroyed(this))
				.subscribe(
					(response) => {
						this.snackBarService.openSuccess('Registration successful!');
						this.router.navigate(['register/success']);
					},
					(error: ApiException) => {
						this.snackBarService.openWarning(error.message);
					}
				);
		} else {
			this.snackBarService.openWarning('Please complete the form and correct any errors before submitting!');
		}
	}

	togglePasswordIcon(): void {
		this.hideRegisterPasswordIcon = !this.hideRegisterPasswordIcon;

		if (this.hideRegisterPasswordIcon) {
			this.registerPasswordIcon = 'visibility';
		} else {
			this.registerPasswordIcon = 'visibility_off';
		}
	}

	toggleConfirmPasswordIcon(): void {
		this.hideConfirmPasswordIcon = !this.hideConfirmPasswordIcon;

		if (this.hideConfirmPasswordIcon) {
			this.confirmPasswordIcon = 'visibility';
		} else {
			this.confirmPasswordIcon = 'visibility_off';
		}
	}

	arePasswordEqualValidator(formGroup: FormGroup): any {
		const password = formGroup.get('password').value;
		const confirmPassword = formGroup.get('confirmPassword').value;

		const isPasswordValid = formGroup.get('password').valid;
		if (!isPasswordValid) {
			return;
		}

		if (password === '' || confirmPassword === '') {
			return;
		}
		if (password !== confirmPassword) {
			formGroup.get('confirmPassword').setErrors({ noPasswordMatch: true });
		}
	}
}
