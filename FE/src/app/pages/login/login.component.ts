import { Component, inject } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SnackBarService } from '@app/services/snack-bar.service';
import { UserService } from '@app/services/user.service';
import { UserValidator } from '@app/validators/user.validator';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';

@Component({
	selector: 'app-login',
	templateUrl: './login.component.html',
	styleUrls: ['./login.component.scss']
})
@UntilDestroy()
export class LoginComponent {
	badCredentials = false;
	passwordIcon = 'visibility';
	hidePassword = true;

	snackBarService = inject(SnackBarService);
	userValidator = inject(UserValidator);
	userService = inject(UserService);

	constructor(private router: Router) {
		this.userService.removeJwtToken();
	}

	emailControl = new FormControl('', [Validators.required, Validators.email]);
	passwordControl = new FormControl('', [Validators.required]);

	loginForm = new FormGroup({
		email: this.emailControl,
		password: this.passwordControl
	});

	onSubmit(): void {
		if (this.loginForm.valid) {
			this.login();
		}
	}

	login(): void {
		const email = this.emailControl.value;
		const password = this.passwordControl.value;

		this.userService
			.login(email, password)
			.pipe(untilDestroyed(this))
			.subscribe(
				() => {
					this.snackBarService.openSuccessSnackBar('Login successful!');
					this.router.navigate(['lessons']);
					this.badCredentials = false;
				},
				() => {
					this.badCredentials = true;
				}
			);
	}

	togglePasswordIcon(): void {
		this.hidePassword = !this.hidePassword;

		if (this.hidePassword) {
			this.passwordIcon = 'visibility';
		} else {
			this.passwordIcon = 'visibility_off';
		}
	}
}
