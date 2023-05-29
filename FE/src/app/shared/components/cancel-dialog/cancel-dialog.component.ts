import { Component } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
	selector: 'app-cancel-dialog',
	templateUrl: './cancel-dialog.component.html',
	styleUrls: ['./cancel-dialog.component.scss']
})
export class CancelDialogComponent {
	constructor(public readonly dialogRef: MatDialogRef<CancelDialogComponent>) {}

	onCancel(): void {
		this.dialogRef.close();
	}

	onConfirm(): void {
		this.dialogRef.close(true);
	}
}
