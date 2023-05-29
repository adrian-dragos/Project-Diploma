import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import {
	GetStudentLessonsListViewModel,
	LessonStatus,
	LessonsClient,
	PageViewModel,
	PagedResultViewModelOfGetStudentLessonsListViewModel
} from '@api/api:';
import { BehaviorSubject, merge } from 'rxjs';

@Component({
	selector: 'app-lessons',
	templateUrl: './lessons.component.html',
	styleUrls: ['./lessons.component.scss']
})
export class LessonsComponent implements OnInit {
	@ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
	@ViewChild(MatSort, { static: true }) sort: MatSort;

	displayedColumns: string[] = ['date', 'time', 'location', 'instructor', 'status'];
	dataSource = new MatTableDataSource<GetStudentLessonsListViewModel>();
	lessonCompleted = LessonStatus.Completed;

	pageIndex = 1;
	pageSize = 10;
	pageSizeOptions = [10, 20, 50];
	pageViewModel: PageViewModel = {
		page: this.pageIndex,
		pageSize: this.pageSize,
		sort: '',
		ascending: false
	};
	totalCount: number;

	constructor(private readonly lessonsClient: LessonsClient) {}

	ngOnInit(): void {
		const start = new BehaviorSubject<void>(undefined);
		start.next();

		merge(this.paginator.page, this.sort.sortChange, start)
			.pipe()
			.subscribe(() => {
				this.pageViewModel = {
					page: this.paginator.pageIndex + 1,
					pageSize: this.paginator.pageSize,
					sort: '',
					ascending: false
				};
				this.fetchLessons();
			});
	}

	fetchLessons(): void {
		this.lessonsClient
			.getStudentLessons(1, this.pageViewModel)
			.subscribe((pagedResult: PagedResultViewModelOfGetStudentLessonsListViewModel) => {
				this.dataSource.data = pagedResult.items;
				this.totalCount = pagedResult.totalCount;
			});
	}

	getLessonStatus(lessonStatus: number): string {
		if (lessonStatus === LessonStatus.Completed) {
			return LessonStatus[lessonStatus];
		}
		return 'Upcoming';
	}
}
