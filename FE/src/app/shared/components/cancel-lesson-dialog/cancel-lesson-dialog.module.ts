import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CancelLessonDialogComponent } from './cancel-lesson-dialog.component';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
	declarations: [CancelLessonDialogComponent],
	imports: [CommonModule, MatButtonModule, MatDialogModule],
	exports: [CancelLessonDialogComponent]
})
export class CancelLessonDialogModule {}
