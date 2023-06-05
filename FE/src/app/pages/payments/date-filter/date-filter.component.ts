import { Component, inject } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { PaymentService } from '@app/services/payment.service';

@Component({
	selector: 'app-date-filter',
	templateUrl: './date-filter.component.html',
	styleUrls: ['./date-filter.component.scss']
})
export class DateFilterComponent {
	range = new FormGroup({
		start: new FormControl<Date | null>(null),
		end: new FormControl<Date | null>(null)
	});

	paymentService = inject(PaymentService);

	onEndDateChange(): void {
		const startDate = new Date(this.range.value.start);
		const endDate = new Date(this.range.value.end);
		this.paymentService.setRangeDate(startDate, endDate);
	}

	clearDatepicker(event: Event): void {
		event.stopPropagation();
		if (this.range.value.start === null && this.range.value.end === null) {
			return;
		}
		this.range.reset();
		this.paymentService.setRangeDate(null, null);
	}
}
