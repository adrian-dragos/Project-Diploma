import { Injectable } from '@angular/core';
import { AbstractControl, AsyncValidatorFn } from '@angular/forms';
import { Client } from '@api/api:';
import { delay, map } from 'rxjs';

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
}
