import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { LessonsComponent } from './lessons.component';
import { MatTableModule } from '@angular/material/table';

@NgModule({
	imports: [CommonModule, RouterModule.forChild([{ path: '', component: LessonsComponent }]), MatTableModule],
	declarations: []
})
export class LessonsModule {}
