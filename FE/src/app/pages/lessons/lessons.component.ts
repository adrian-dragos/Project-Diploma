import { AfterContentInit, Component, ViewChild, inject } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import {
	GetLessonsViewModel,
	GetStudentLessonsViewModel,
	LessonStatus,
	LessonsClient,
	PageViewModel,
	PagedResultViewModelOfGetStudentLessonsViewModel
} from '@api/api:';
import { TooltipConstants } from '@app/constants/tooltip.constants';
import { DialogService } from '@app/services/dialog.service';
import { LessonsService } from '@app/services/lessons.service';
import { SnackBarService } from '@app/services/snack-bar.service';
import { CancelLessonDialogComponent } from '@app/shared/components/cancel-lesson-dialog/cancel-lesson-dialog.component';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { BehaviorSubject, merge, tap } from 'rxjs';

@Component({
	selector: 'app-lessons',
	templateUrl: './lessons.component.html',
	styleUrls: ['./lessons.component.scss']
})
@UntilDestroy()
export class LessonsComponent implements AfterContentInit {
	@ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
	@ViewChild(MatSort, { static: true }) sort: MatSort;

	readonly showDelay = TooltipConstants.SHOW_DELAY;
	readonly displayedColumns: string[] = ['date', 'time', 'location', 'instructor', 'status', 'actions'];
	start = new BehaviorSubject<void>(undefined);
	dataSource = new MatTableDataSource<GetStudentLessonsViewModel>();
	lessonCompleted = LessonStatus.Completed;
	isLoading = false;
	userRole: string;
	tooltipShowDelay = TooltipConstants.SHOW_DELAY;

	pageIndex = 0;
	pageSize = 10;
	pageSizeOptions = [10, 20, 50];
	pageViewModel: PageViewModel = {
		page: this.pageIndex,
		pageSize: this.pageSize,
		sort: '',
		ascending: false
	};
	totalCount: number;
	filter: GetLessonsViewModel = {
		studentIds: [],
		instructorIds: [],
		startDate: null,
		endDate: null,
		lessonStatuses: [],
		page: this.pageViewModel
	};

	dialogService = inject(DialogService);
	snackBarService = inject(SnackBarService);
	lessonService = inject(LessonsService);

	constructor(private readonly lessonsClient: LessonsClient) {}

	ngAfterContentInit(): void {
		this.userRole = localStorage.getItem('userRole');

		merge(this.paginator.page, this.sort.sortChange)
			.pipe(
				tap(() => (this.isLoading = true)),
				untilDestroyed(this)
			)
			.subscribe(() => {
				this.filter.page = {
					page: this.paginator.pageIndex + 1,
					pageSize: this.paginator.pageSize,
					sort: '',
					ascending: this.sort.direction === 'asc'
				};
				this.fetchLessons();
			});

		this.userRole = localStorage.getItem('userRole');
		if (this.userRole === 'student') {
			const studentId = [parseInt(localStorage.getItem('userId'), 10)];
			this.lessonService.setStudentFilter(studentId);
		} else {
			this.lessonService.setStudentFilter([]);
		}

		this.lessonService
			.getLessonsFilter()
			.pipe(
				tap(() => (this.isLoading = true)),
				untilDestroyed(this)
			)
			.subscribe((filter) => {
				this.filter.studentIds = filter.studentIds;
				this.filter.instructorIds = filter.instructorIds;
				this.filter.startDate = filter.startDate;
				this.filter.endDate = filter.endDate;
				this.filter.lessonStatuses = filter.lessonStatuses;
				if (filter.startDate !== null) {
					this.filter.page = { ...this.filter.page, ascending: true };
					this.sort.direction = 'asc';
				}
				this.filter.page.page = 1;
				this.paginator.pageIndex = 0;
				this.pageIndex = 0;
				this.fetchLessons();
			});
	}

	fetchLessons(): void {
		this.lessonsClient
			.getStudentLessons(this.filter)
			.pipe(untilDestroyed(this))
			.subscribe((pagedResult: PagedResultViewModelOfGetStudentLessonsViewModel) => {
				this.dataSource.data = pagedResult.items;
				this.totalCount = pagedResult.totalCount;
				this.isLoading = false;
			});
	}

	deleteLesson(lessonId: number, status: LessonStatus): void {
		if (status !== LessonStatus.BookedPaid) {
			return;
		}

		const dialogRef = this.dialogService.openDialog(CancelLessonDialogComponent, {
			title: 'Delete lesson',
			message: 'Are you sure you want to delete this lesson?',
			confirmationButtonText: 'Confirm',
			cancelButtonText: 'Cancel'
		});

		dialogRef
			.afterClosed()
			.pipe(untilDestroyed(this))
			.subscribe((result) => {
				if (result) {
					this.lessonsClient
						.cancelLesson(lessonId)
						.pipe(untilDestroyed(this))
						.subscribe(
							() => {
								this.snackBarService.openSuccessSnackBar('Lesson cancelled successfully!');
								this.start.next();
							},
							() => this.snackBarService.openErrorSnackBar('Could not delete lesson!')
						);
				}
			});
	}

	getLessonStatus(lessonStatus: number): string {
		if (lessonStatus === LessonStatus.Completed) {
			return LessonStatus[lessonStatus];
		}
		return 'Upcoming';
	}
}
