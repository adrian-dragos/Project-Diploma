import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookingComponent } from './booking.component';
import { RouterModule } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatExpansionModule } from '@angular/material/expansion';
import { BookingLessonsComponent } from './booking-lessons/booking-lessons.component';
import { BookingSidebarComponent } from './booking-sidebar/booking-sidebar.component';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatCardModule } from '@angular/material/card';
import { MatNativeDateModule } from '@angular/material/core';
import { MatButtonModule } from '@angular/material/button';
import { MatChipsModule } from '@angular/material/chips';
import { InstructorClient } from '@api/api:';

@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([{ path: '', component: BookingComponent }]),
		MatIconModule,
		MatSelectModule,
		MatFormFieldModule,
		MatExpansionModule,
		MatDatepickerModule,
		MatCardModule,
		MatNativeDateModule,
		MatButtonModule,
		MatChipsModule
	],
	providers: [InstructorClient],
	declarations: [BookingComponent, BookingSidebarComponent, BookingLessonsComponent]
})
export class BookingModule {}
