import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardPaymentComponent } from './card-payment.component';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

@NgModule({
	imports: [CommonModule, RouterModule.forChild([{ path: '', component: CardPaymentComponent }]), ReactiveFormsModule],
	declarations: [CardPaymentComponent]
})
export class CardPaymentModule {}
