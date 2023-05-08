import { Component, inject } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ApiException, Client, LoginUserRequestViewModel } from '@api/api:';
import { SnackBarService } from '@app/services/snack-bar.service';
import { UserValidator } from '@app/validators/user.validator';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { tap } from 'rxjs';

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

	constructor(private client: Client, private router: Router) {}

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
		const user: LoginUserRequestViewModel = new LoginUserRequestViewModel({ email, password });

		this.client
			.login(user)
			.pipe(
				tap((x) => console.log(x)),
				untilDestroyed(this)
			)
			.subscribe(
				(response) => {
					this.snackBarService.openSuccess('Login successful!');
					this.router.navigate(['/home']);
					this.badCredentials = false;
				},
				(error: ApiException) => {
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
