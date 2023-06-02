import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LessonDetailsDialogComponent } from './lesson-details-dialog.component';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';
import { CancelLessonDialogModule } from '../cancel-lesson-dialog/cancel-lesson-dialog.module';
import { SnackBarService } from '@app/services/snack-bar.service';
import { DialogService } from '@app/services/dialog.service';
import { LessonsClient } from '@api/api:';

@NgModule({
	imports: [CommonModule, MatButtonModule, MatDialogModule, MatIconModule, MatTooltipModule, CancelLessonDialogModule],
	declarations: [LessonDetailsDialogComponent],
	exports: [LessonDetailsDialogComponent],
	providers: [DialogService, SnackBarService, LessonsClient]
})
export class LessonDetailsDialogModule {}
