import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { GetStudentLessonsListViewModel, LessonsClient } from '@api/api:';
import { DatePipe } from '@angular/common';

@Component({
	selector: 'app-lessons',
	templateUrl: './lessons.component.html',
	styleUrls: ['./lessons.component.scss']
})
export class LessonsComponent implements OnInit {
	displayedColumns: string[] = ['date', 'time', 'location', 'instructor'];
	dataSource = new MatTableDataSource<GetStudentLessonsListViewModel>();

	constructor(private readonly lessonsClient: LessonsClient) {}

	ngOnInit(): void {
		this.lessonsClient.getStudentLessons(1).subscribe((lessons: GetStudentLessonsListViewModel[]) => {
			this.dataSource.data = lessons;
		});
	}
}
