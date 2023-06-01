import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LessonDetailsDialogComponent } from './lesson-details-dialog.component';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';

@NgModule({
	imports: [CommonModule, MatButtonModule, MatDialogModule, MatIconModule, MatTooltipModule],
	declarations: [LessonDetailsDialogComponent],
	exports: [LessonDetailsDialogComponent]
})
export class LessonDetailsDialogModule {}
