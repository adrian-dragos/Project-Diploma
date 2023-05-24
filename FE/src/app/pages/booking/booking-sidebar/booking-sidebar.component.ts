import { Component } from '@angular/core';

@Component({
	selector: 'app-booking-sidebar',
	templateUrl: './booking-sidebar.component.html',
	styleUrls: ['./booking-sidebar.component.scss']
})
export class BookingSidebarComponent {
	today = new Date();
}
