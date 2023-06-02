import { Injectable } from '@angular/core';
import { MatSnackBar, MatSnackBarRef, TextOnlySnackBar } from '@angular/material/snack-bar';

@Injectable({
	providedIn: 'root'
})
export class SnackBarService {
	private readonly durationInMilliseconds = 3000;

	constructor(private snackBar: MatSnackBar) {}

	openSuccessSnackBar(message: string): MatSnackBarRef<TextOnlySnackBar> {
		return this.snackBar.open(message, undefined, {
			verticalPosition: 'top',
			horizontalPosition: 'center',
			duration: this.durationInMilliseconds,
			panelClass: ['success-snackbar']
		});
	}

	openWarningSnackBar(message: string): MatSnackBarRef<TextOnlySnackBar> {
		return this.snackBar.open(message, undefined, {
			verticalPosition: 'top',
			horizontalPosition: 'center',
			duration: this.durationInMilliseconds,
			panelClass: ['warning-snackbar']
		});
	}

	openErrorSnackBar(message: string): MatSnackBarRef<TextOnlySnackBar> {
		return this.snackBar.open(message, undefined, {
			verticalPosition: 'top',
			horizontalPosition: 'center',
			duration: this.durationInMilliseconds,
			panelClass: ['error-snackbar']
		});
	}
}
