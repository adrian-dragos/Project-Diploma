import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ApiException, Client, RegisterUserRequestViewModel } from '@app/api/api';
import { SnackBarService } from '@app/services/snack-bar.service';

@Component({
	selector: 'app-register',
	templateUrl: './register.component.html',
	styleUrls: ['./register.component.scss']
})
export class RegisterComponent {
	//TODO: Add password validation for matching passwords, for password length and for password strength
	snackBarService = inject(SnackBarService);
	router = inject(Router);

	constructor(private client: Client, private http: HttpClient) {}

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

			this.client.register(user).subscribe(
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
