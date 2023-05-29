import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { LessonsComponent } from './lessons.component';
import { MatTableModule } from '@angular/material/table';
import { LessonsClient } from '@api/api:';
import { MatDividerModule } from '@angular/material/divider';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';

@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([{ path: '', component: LessonsComponent }]),
		MatTableModule,
		MatSortModule,
		MatDividerModule,
		MatPaginatorModule
	],
	declarations: [LessonsComponent],
	providers: [LessonsClient]
})
export class LessonsModule {}
