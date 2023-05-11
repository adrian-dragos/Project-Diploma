import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { LessonsComponent } from './lessons.component';

@NgModule({
	declarations: [],
	imports: [CommonModule, RouterModule.forChild([{ path: '', component: LessonsComponent }])]
})
export class LessonsModule {}
