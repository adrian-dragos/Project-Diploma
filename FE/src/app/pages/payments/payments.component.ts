import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';

@Component({
	selector: 'app-payments',
	templateUrl: './payments.component.html',
	styleUrls: ['./payments.component.scss']
})
export class PaymentsComponent {
	isLoading = false;
	dataSource: MatTableDataSource<any>;
	columns: string[] = ['date', 'sum', 'paymentMethod', 'addedBy'];

	constructor() {
		const data = [
			{ date: new Date(2023, 6, 1, 11, 39), sum: '100 lei', paymentMethod: 'Cash', addedBy: 'Dragos Adrian' },
			{ date: new Date(2023, 5, 1, 7, 8), sum: '500 lei', paymentMethod: 'Cash', addedBy: 'John Smith' },
			{ date: new Date(2023, 4, 29, 14, 12), sum: '80 lei', paymentMethod: 'Credit Card', addedBy: 'Dragos Adrian' },
			{ date: new Date(2023, 4, 21, 14, 41), sum: '300 lei', paymentMethod: 'Cash', addedBy: 'Dragos Adrian' }
		];

		this.dataSource = new MatTableDataSource(data);
	}
}
