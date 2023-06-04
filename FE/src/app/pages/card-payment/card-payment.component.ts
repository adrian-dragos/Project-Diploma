import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { PaymentClient, PaymentMethod } from '@api/api:';
import { SnackBarService } from '@app/services/snack-bar.service';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { CreditCard, CreditCardValidators } from 'angular-cc-library';
import { defer, delay, map, tap } from 'rxjs';

@Component({
	selector: 'app-card-payment',
	templateUrl: './card-payment.component.html',
	styleUrls: ['./card-payment.component.scss']
})
@UntilDestroy()
export class CardPaymentComponent implements OnInit {
	form: FormGroup;
	type: string | undefined;
	sumToPay = 0;
	isLoading = true;
	paymentClient = inject(PaymentClient);
	snackBarService = inject(SnackBarService);

	constructor(private readonly router: Router, private readonly fb: FormBuilder) {}

	ngOnInit(): void {
		this.form = this.fb.group({
			creditCard: ['', [CreditCardValidators.validateCCNumber]],
			expDate: ['', [CreditCardValidators.validateExpDate]],
			cardHolder: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(50)]],
			cvc: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(4)]]
		});

		defer(() => this.form.get('creditCard').valueChanges)
			.pipe(map((num: string) => CreditCard.cardType(num)))
			.subscribe((type) => {
				this.type = type;
				console.log(type);
			});

		this.paymentClient
			.getSumToPay(1)
			.pipe(untilDestroyed(this))
			.subscribe((sumToPay) => {
				this.sumToPay = sumToPay;
				this.isLoading = false;
			});
	}

	public goToNextField(controlName: string, nextField: HTMLInputElement): void {
		if (this.form.get(controlName).value.length === 16 && controlName === 'creditCard') {
			nextField.focus();
		}

		if (this.form.get(controlName).value.length === 16 && controlName === 'creditCard') {
			nextField.focus();
		}

		if (this.form.get(controlName)?.valid) {
			nextField.focus();
		}
	}

	public onSubmit(): void {
		if (this.form.invalid) {
			console.log('invalid form');
			return;
		}
		this.paymentClient
			.pay({
				studentId: 1,
				amount: this.sumToPay,
				paymentMethod: PaymentMethod.Card
			})
			.pipe(
				tap(() => (this.isLoading = true)),
				delay(1000),
				untilDestroyed(this)
			)
			.subscribe(() => {
				this.snackBarService.openSuccessSnackBar('Payment successful');
				this.isLoading = false;
				this.router.navigate(['/payments']);
			});
	}
}
