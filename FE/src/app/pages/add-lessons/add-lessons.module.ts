import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddLessonsComponent } from './add-lessons.component';
import { RouterModule } from '@angular/router';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatIconModule } from '@angular/material/icon';
import { MatSelectModule } from '@angular/material/select';
import { InstructorPickerComponent } from './instructor-picker/instructor-picker.component';
import { InstructorClient, LessonsClient } from '@api/api:';
import { MatCardModule } from '@angular/material/card';
import { AddLessonService } from '@app/services/add-lesson.service';
import { FormsModule } from '@angular/forms';

@NgModule({
	imports: [
		RouterModule.forChild([{ path: '', component: AddLessonsComponent }]),
		CommonModule,
		MatButtonModule,
		MatInputModule,
		MatFormFieldModule,
		ReactiveFormsModule,
		MatDatepickerModule,
		MatNativeDateModule,
		MatIconModule,
		MatSelectModule,
		MatCardModule,
		FormsModule
	],
	declarations: [AddLessonsComponent, InstructorPickerComponent],
	providers: [InstructorClient, AddLessonService, LessonsClient]
})
export class AddLessonsModule {}
