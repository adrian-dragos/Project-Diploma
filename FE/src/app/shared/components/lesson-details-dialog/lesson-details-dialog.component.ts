import { Component, Inject, inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { TooltipConstants } from '@app/constants/tooltip.constants';

@Component({
	selector: 'app-lesson-details-dialog',
	templateUrl: './lesson-details-dialog.component.html',
	styleUrls: ['./lesson-details-dialog.component.scss']
})
export class LessonDetailsDialogComponent {
	readonly showDelay = TooltipConstants.SHOW_DELAY;

	constructor(public readonly dialogRef: MatDialogRef<LessonDetailsDialogComponent>, @Inject(MAT_DIALOG_DATA) public data: any) {}
}
