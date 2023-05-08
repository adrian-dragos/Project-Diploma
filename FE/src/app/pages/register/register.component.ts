import { Component, inject } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ApiException, Client, RegisterUserRequestViewModel } from '@app/api/api';
import { SnackBarService } from '@app/services/snack-bar.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-register',
	templateUrl: './register.component.html',
	styleUrls: ['./register.component.scss']
})
@UntilDestroy()
export class RegisterComponent {
	//TODO: Add password validation for matching passwords, for password length and for password strength
	snackBarService = inject(SnackBarService);
	router = inject(Router);

	constructor(private readonly client: Client) {}

	emailControl = new FormControl('', [Validators.required, Validators.email]);
	passwordControl = new FormControl('', [Validators.required]);
	confirmPasswordControl = new FormControl('', [Validators.required]);

	registerForm = new FormGroup({
		email: this.emailControl,
		password: this.passwordControl,
		confirmPassword: this.confirmPasswordControl
	});

	onSubmit(): void {
		console.log(this.registerForm.value);

		if (this.registerForm.valid) {
			const email = this.emailControl.value;
			const password = this.passwordControl.value;

			const user: RegisterUserRequestViewModel = new RegisterUserRequestViewModel({ email, password });

			this.client
				.register(user)
				.pipe(untilDestroyed(this))
				.subscribe(
					(response) => {
						console.log(response);
						this.snackBarService.openSuccess('Registration successful!');
						this.router.navigate(['/login']);
					},
					(error: ApiException) => {
						console.log(error);
						this.snackBarService.openWarning(error.message);
					}
				);
		} else {
			this.snackBarService.openWarning('Invalid form');
		}
	}
}
