import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
	selector: 'app-lesson-details-dialog',
	templateUrl: './lesson-details-dialog.component.html',
	styleUrls: ['./lesson-details-dialog.component.scss']
})
export class LessonDetailsDialogComponent {
	constructor(public readonly dialogRef: MatDialogRef<LessonDetailsDialogComponent>, @Inject(MAT_DIALOG_DATA) public data: any) {}
}
