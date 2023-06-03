import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardPaymentComponent } from './card-payment.component';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { PaymentClient } from '@api/api:';

@NgModule({
	imports: [CommonModule, RouterModule.forChild([{ path: '', component: CardPaymentComponent }]), ReactiveFormsModule],
	declarations: [CardPaymentComponent],
	providers: [PaymentClient]
})
export class CardPaymentModule {}
