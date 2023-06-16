import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AddUserViewModel, UsersClient } from '@api/api:';
import { SnackBarService } from '@app/services/snack-bar.service';
import { UserService } from '@app/services/user.service';
import { UserValidator } from '@app/validators/user.validator';

@Component({
	selector: 'app-add-user',
	templateUrl: './add-user.component.html',
	styleUrls: ['./add-user.component.scss']
})
export class AddUserComponent implements OnInit {
	form: FormGroup;
	projectOptions: any[];
	displayedRoles: string[];

	snackBarService = inject(SnackBarService);
	userClient = inject(UsersClient);
	userValidator = inject(UserValidator);

	constructor(private readonly fb: FormBuilder) {
		this.getFilterOptions();
	}

	ngOnInit(): void {
		this.form = this.fb.group({
			firstName: new FormControl('', Validators.required),
			lastName: new FormControl('', Validators.required),
			email: new FormControl('', [Validators.required, Validators.email], this.userValidator.checkUniqueEmail()),
			role: new FormControl('', Validators.required)
		});
	}

	submit(): void {
		if (this.form.valid) {
			let roleId: number;
			switch (this.form.value.role) {
				case 'Admin':
					roleId = 1;
					break;
				case 'Instructor':
					roleId = 3;
					break;
			}

			const user: AddUserViewModel = {
				firstName: this.form.value.firstName,
				lastName: this.form.value.lastName,
				email: this.form.value.email,
				roleId: roleId
			};
			this.userClient.addUser(user).subscribe(
				() => this.snackBarService.openSuccessSnackBar('Successfully sent join request'),
				(error) => this.snackBarService.openErrorSnackBar(error.message)
			);
		}
	}

	getFilterOptions(): void {
		const displayedStatusEnum = DisplayedRoles;
		const keys = Object.keys(displayedStatusEnum);
		this.displayedRoles = keys.slice(keys.length / 2);
	}
}

enum DisplayedRoles {
	Admin,
	Instructor
}
