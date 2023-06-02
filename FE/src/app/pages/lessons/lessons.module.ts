import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { LessonsComponent } from './lessons.component';
import { MatTableModule } from '@angular/material/table';
import { LessonsClient } from '@api/api:';
import { MatDividerModule } from '@angular/material/divider';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { LoadingSpinnerModule } from '@app/shared/components/loading-spinner/loading-spinner.module';
import { MatIconModule } from '@angular/material/icon';
import { DialogService } from '@app/services/dialog.service';
import { CancelLessonDialogModule } from '@app/shared/components/cancel-lesson-dialog/cancel-lesson-dialog.module';
import { MatButtonModule } from '@angular/material/button';

@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([{ path: '', component: LessonsComponent }]),
		MatTableModule,
		MatSortModule,
		MatDividerModule,
		MatPaginatorModule,
		LoadingSpinnerModule,
		MatIconModule,
		CancelLessonDialogModule,
		MatButtonModule
	],
	declarations: [LessonsComponent],
	providers: [LessonsClient, DialogService]
})
export class LessonsModule {}
