import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';

@Component({
	selector: 'app-lessons',
	templateUrl: './lessons.component.html',
	styleUrls: ['./lessons.component.scss']
})
export class LessonsComponent {
	displayedColumns: string[] = ['date', 'hour', 'name', 'instructor'];

	dataSource = new MatTableDataSource<any>(); // Replace `any` with your data type

	// You can set the data for your table in this component
	ngOnInit() {
		this.dataSource.data = [
			{ name: 'John Doe', age: 25 },
			{ name: 'Jane Smith', age: 32 }
			// Add more data objects as needed
		];
	}
}
