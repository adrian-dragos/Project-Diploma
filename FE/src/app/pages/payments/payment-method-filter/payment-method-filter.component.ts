import { Component, inject } from '@angular/core';
import { MatSelectChange } from '@angular/material/select';
import { PaymentMethod } from '@api/api:';
import { PaymentService } from '@app/services/payment.service';

@Component({
	selector: 'app-payment-method-filter',
	templateUrl: './payment-method-filter.component.html',
	styleUrls: ['./payment-method-filter.component.scss']
})
export class PaymentMethodFilterComponent {
	displayedMethods: string[];
	selectedValues: DisplayedPaymentMethod[] = [];

	paymentService = inject(PaymentService);

	constructor() {
		this.getFilterOptions();
	}

	getFilterOptions(): void {
		const displayedStatusEnum = DisplayedPaymentMethod;
		const keys = Object.keys(displayedStatusEnum);
		this.displayedMethods = keys.slice(keys.length / 2);
	}

	onSelectionChange(event: MatSelectChange): void {
		const paymentMethod = event.value.map((value: string) => {
			switch (value) {
				case 'Cash':
					return PaymentMethod.Cash;
				case 'Card':
					return PaymentMethod.Card;
				default:
					return null;
			}
		});

		this.paymentService.setPaymentMethod(paymentMethod);
	}

	clearSelectedItems(event: Event): void {
		event.stopPropagation();
		if (this.selectedValues.length === 0) {
			return;
		}
		this.paymentService.setPaymentMethod([]);
		this.selectedValues = [];
	}
}

enum DisplayedPaymentMethod {
	Card,
	Cash
}
