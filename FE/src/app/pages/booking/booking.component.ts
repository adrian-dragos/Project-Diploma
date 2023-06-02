import { Component, inject } from '@angular/core';
import { TooltipConstants } from '@app/constants/tooltip.constants';
import { BookingService } from '@app/services/booking.service';
import { UntilDestroy } from '@ngneat/until-destroy';

@Component({
	selector: 'app-booking',
	templateUrl: './booking.component.html',
	styleUrls: ['./booking.component.scss']
})
@UntilDestroy()
export class BookingComponent {
	tooltipShowDelay = TooltipConstants.SHOW_DELAY;
	bookingService = inject(BookingService);
}
