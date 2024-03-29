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
import { CarClient, InstructorClient, LessonsClient, PaymentClient, StudentClient } from '@api/api:';
import { MatRadioModule } from '@angular/material/radio';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { GearButtonsComponent } from './booking-sidebar/gear-buttons/gear-buttons.component';
import { CarFilterComponent } from './booking-sidebar/car-filter/car-filter.component';
import { BookingService } from '@app/services/booking.service';
import { LoadingSpinnerModule } from '@app/shared/components/loading-spinner/loading-spinner.module';
import { DialogService } from '@app/services/dialog.service';
import { LessonDetailsDialogModule } from '@app/shared/components/lesson-details-dialog/lesson-details-dialog.module';
import { MatTooltipModule } from '@angular/material/tooltip';
import { PaymentService } from '@app/services/payment.service';
import { LoginDialogModule } from '@app/shared/components/login-dialog/login-dialog.module';
import { StudentSelectionComponent } from './student-selection/student-selection.component';

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
		MatChipsModule,
		MatRadioModule,
		ReactiveFormsModule,
		FormsModule,
		LoadingSpinnerModule,
		LessonDetailsDialogModule,
		MatTooltipModule,
		LoginDialogModule
	],
	providers: [InstructorClient, CarClient, BookingService, LessonsClient, DialogService, PaymentClient, PaymentService, StudentClient],
	declarations: [
		BookingComponent,
		BookingSidebarComponent,
		BookingLessonsComponent,
		GearButtonsComponent,
		CarFilterComponent,
		StudentSelectionComponent
	]
})
export class BookingModule {}
