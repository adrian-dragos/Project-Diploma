import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { LessonsComponent } from './lessons.component';
import { MatTableModule } from '@angular/material/table';
import { InstructorClient, LessonsClient, StudentClient } from '@api/api:';
import { MatDividerModule } from '@angular/material/divider';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { LoadingSpinnerModule } from '@app/shared/components/loading-spinner/loading-spinner.module';
import { MatIconModule } from '@angular/material/icon';
import { DialogService } from '@app/services/dialog.service';
import { CancelLessonDialogModule } from '@app/shared/components/cancel-lesson-dialog/cancel-lesson-dialog.module';
import { MatButtonModule } from '@angular/material/button';
import { MatTooltipModule } from '@angular/material/tooltip';
import { StatusFilterComponent } from './status-filter/status-filter.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';
import { InstructorFilterComponent } from './instructor-filter/instructor-filter.component';
import { DateFilterComponent } from './date-filter/date-filter.component';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { StudentFilterComponent } from './student-filter/student-filter.component';
import { LessonsService } from '@app/services/lessons.service';

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
		MatButtonModule,
		MatTooltipModule,
		ReactiveFormsModule,
		FormsModule,
		MatSelectModule,
		MatDatepickerModule,
		MatNativeDateModule
	],
	declarations: [LessonsComponent, StatusFilterComponent, InstructorFilterComponent, DateFilterComponent, StudentFilterComponent],
	providers: [LessonsClient, DialogService, InstructorClient, StudentClient, LessonsService]
})
export class LessonsModule {}
