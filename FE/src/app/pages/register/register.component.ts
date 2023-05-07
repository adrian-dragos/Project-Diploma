import { Component, inject } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
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
			this.snackBarService.openSuccess('Registration successful');
			this.router.navigate(['/login']);
		} else {
			this.snackBarService.openWarning('Invalid form');
		}
	}
}
