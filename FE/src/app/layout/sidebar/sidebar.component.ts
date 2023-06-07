import { Component } from '@angular/core';

@Component({
	selector: 'app-sidebar',
	templateUrl: './sidebar.component.html',
	styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent {
	role: string;
	constructor() {
		this.role = localStorage.getItem('userRole');
		console.log(this.role);
	}
}
