import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaymentsComponent } from './payments.component';
import { RouterModule } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';
import { LoadingSpinnerModule } from '@app/shared/components/loading-spinner/loading-spinner.module';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CreditCardDirectivesModule } from 'angular-cc-library';
import { PaymentClient } from '@api/api:';
import { MatTooltipModule } from '@angular/material/tooltip';
import { DateFilterComponent } from './date-filter/date-filter.component';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { PaymentMethodFilterComponent } from './payment-method-filter/payment-method-filter.component';
import { PaymentService } from '@app/services/payment.service';
import { StudentFilterComponent } from './student-filter/student-filter.component';

@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([{ path: '', component: PaymentsComponent }]),
		MatIconModule,
		LoadingSpinnerModule,
		MatButtonModule,
		MatTableModule,
		ReactiveFormsModule,
		CreditCardDirectivesModule,
		MatTooltipModule,
		FormsModule,
		MatSelectModule,
		MatDatepickerModule,
		MatNativeDateModule
	],
	declarations: [PaymentsComponent, DateFilterComponent, PaymentMethodFilterComponent, StudentFilterComponent],
	providers: [PaymentClient, PaymentService]
})
export class PaymentsModule {}
