import { Injectable } from '@angular/core';
import { AbstractControl, AsyncValidatorFn } from '@angular/forms';
import { Client, LoginUserRequestViewModel } from '@api/api:';
import { catchError, delay, map, of } from 'rxjs';

@Injectable({
	providedIn: 'root'
})
export class UserValidator {
	constructor(private readonly client: Client) {}

	checkUniqueEmail(): AsyncValidatorFn {
		return (control: AbstractControl) => {
			return this.client.unique(control.value).pipe(
				delay(200),
				map((response) => (response ? { emailExists: true } : null))
			);
		};
	}

	// checkCredentials(passwordControl: AbstractControl): AsyncValidatorFn {
	// 	const parent = passwordControl && passwordControl.parent;
	// 	const emailControl = parent.get('email');

	// 	const email = emailControl.value;
	// 	const password = passwordControl.value;
	// 	const user: LoginUserRequestViewModel = new LoginUserRequestViewModel({ email, password });

	// 	return (control: AbstractControl) => {
	// 		return this.client.login(user).pipe(
	// 			delay(200),
	// 			catchError((error) => of(true)),
	// 			map((response) => (typeof response === 'string' ? null : { badCredentials: true }))
	// 		);
	// 	};
	// }
}
