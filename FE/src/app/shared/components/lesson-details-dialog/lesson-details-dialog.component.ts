import { Component, Inject, inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { TooltipConstants } from '@app/constants/tooltip.constants';
import { DialogService } from '@app/services/dialog.service';
import { CancelLessonDialogComponent } from '../cancel-lesson-dialog/cancel-lesson-dialog.component';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { SnackBarService } from '@app/services/snack-bar.service';
import { LessonsClient } from '@api/api:';

@Component({
	selector: 'app-lesson-details-dialog',
	templateUrl: './lesson-details-dialog.component.html',
	styleUrls: ['./lesson-details-dialog.component.scss']
})
@UntilDestroy()
export class LessonDetailsDialogComponent {
	readonly showDelay = TooltipConstants.SHOW_DELAY;

	dialogService = inject(DialogService);
	snackBarService = inject(SnackBarService);
	lessonClient = inject(LessonsClient);
	constructor(public readonly dialogRef: MatDialogRef<LessonDetailsDialogComponent>, @Inject(MAT_DIALOG_DATA) public data: any) {}

	onDeleteClick(): void {
		const dialogRef = this.dialogService.openDialog(CancelLessonDialogComponent, {
			title: 'Unbook lesson',
			message: 'Are you sure you want to unbook this lesson?',
			confirmationButtonText: 'Confirm',
			cancelButtonText: 'Cancel'
		});

		dialogRef
			.afterClosed()
			.pipe(untilDestroyed(this))
			.subscribe((result) => {
				if (result) {
					this.dialogRef.close(true);
				}
			});
	}
}
