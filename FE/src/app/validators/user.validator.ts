import { Injectable } from '@angular/core';
import { AbstractControl, AsyncValidatorFn } from '@angular/forms';
import { UsersClient } from '@api/api:';
import { delay, map } from 'rxjs';

@Injectable({
	providedIn: 'root'
})
export class UserValidator {
	constructor(private readonly client: UsersClient) {}

	checkUniqueEmail(): AsyncValidatorFn {
		return (control: AbstractControl) => {
			return this.client.checkEmailIsUnique(control.value).pipe(
				delay(200),
				map((response) => (response ? null : { emailExists: true }))
			);
		};
	}
}
