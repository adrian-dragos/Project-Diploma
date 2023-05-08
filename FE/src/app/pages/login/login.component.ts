import { Component, inject } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ApiException, Client, LoginUserRequestViewModel } from '@api/api:';
import { SnackBarService } from '@app/services/snack-bar.service';

@Component({
	selector: 'app-login',
	templateUrl: './login.component.html',
	styleUrls: ['./login.component.scss']
})
export class LoginComponent {
	loginFailed = false;
	snackBarService = inject(SnackBarService);

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

		this.client.login(user).subscribe(
			(response) => {
				this.snackBarService.openSuccess('Login successful!');
				this.router.navigate(['/home']);
			},
			(error: ApiException) => {
				this.loginFailed = true;
				console.log(this.loginFailed);
			}
		);
	}
}
