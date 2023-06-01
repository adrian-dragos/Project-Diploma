import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
	selector: 'app-cancel-lesson-dialog',
	templateUrl: './cancel-lesson-dialog.component.html',
	styleUrls: ['./cancel-lesson-dialog.component.scss']
})
export class CancelLessonDialogComponent {
	constructor(public readonly dialogRef: MatDialogRef<CancelLessonDialogComponent>, @Inject(MAT_DIALOG_DATA) public data: any) {}
}
