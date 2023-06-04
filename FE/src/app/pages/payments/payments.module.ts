import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaymentsComponent } from './payments.component';
import { RouterModule } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';
import { LoadingSpinnerModule } from '@app/shared/components/loading-spinner/loading-spinner.module';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { ReactiveFormsModule } from '@angular/forms';
import { CreditCardDirectivesModule } from 'angular-cc-library';
import { PaymentClient } from '@api/api:';
import { MatTooltipModule } from '@angular/material/tooltip';

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
		MatTooltipModule
	],
	declarations: [PaymentsComponent],
	providers: [PaymentClient]
})
export class PaymentsModule {}
