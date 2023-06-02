import { AfterContentInit, Component, ViewChild, inject } from '@angular/core';
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
import { TooltipConstants } from '@app/constants/tooltip.constants';
import { DialogService } from '@app/services/dialog.service';
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
	dataSource = new MatTableDataSource<GetStudentLessonsListViewModel>();
	lessonCompleted = LessonStatus.Completed;
	isLoading = false;

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

	dialogService = inject(DialogService);
	snackBarService = inject(SnackBarService);

	constructor(private readonly lessonsClient: LessonsClient) {}

	ngAfterContentInit(): void {
		this.start.next();

		merge(this.paginator.page, this.sort.sortChange, this.start)
			.pipe(
				tap(() => (this.isLoading = true)),
				untilDestroyed(this)
			)
			.subscribe(() => {
				this.pageViewModel = {
					page: this.paginator.pageIndex + 1,
					pageSize: this.paginator.pageSize,
					sort: '',
					ascending: this.sort.direction === 'asc'
				};
				this.fetchLessons();
			});
	}

	fetchLessons(): void {
		this.lessonsClient
			.getStudentLessons(1, this.pageViewModel)
			.pipe(untilDestroyed(this))
			.subscribe((pagedResult: PagedResultViewModelOfGetStudentLessonsListViewModel) => {
				this.dataSource.data = pagedResult.items;
				this.totalCount = pagedResult.totalCount;
				this.isLoading = false;
			});
	}

	deleteLesson(lessonId: number): void {
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
