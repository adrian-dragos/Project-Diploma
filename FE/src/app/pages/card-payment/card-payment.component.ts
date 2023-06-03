import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UntilDestroy } from '@ngneat/until-destroy';
import { CreditCard, CreditCardValidators } from 'angular-cc-library';
import { defer, map } from 'rxjs';

@Component({
	selector: 'app-card-payment',
	templateUrl: './card-payment.component.html',
	styleUrls: ['./card-payment.component.scss']
})
@UntilDestroy()
export class CardPaymentComponent implements OnInit {
	form: FormGroup;
	submitted = false;
	constructor(private readonly fb: FormBuilder) {}
	type: string | undefined;

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

	public onSubmit(demoForm: FormGroup): void {
		this.submitted = true;
		console.log(demoForm.value);
		console.log(demoForm);
	}
}
