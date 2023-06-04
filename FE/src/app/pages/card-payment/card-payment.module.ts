import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardPaymentComponent } from './card-payment.component';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { PaymentClient } from '@api/api:';
import { SnackBarService } from '@app/services/snack-bar.service';
import { LoadingSpinnerModule } from '@app/shared/components/loading-spinner/loading-spinner.module';

@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([{ path: '', component: CardPaymentComponent }]),
		ReactiveFormsModule,
		LoadingSpinnerModule
	],
	declarations: [CardPaymentComponent],
	providers: [PaymentClient, SnackBarService]
})
export default class CardPaymentModule {}
