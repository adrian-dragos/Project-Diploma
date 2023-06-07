import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddLessonsComponent } from './add-lessons.component';
import { RouterModule } from '@angular/router';

@NgModule({
	imports: [RouterModule.forChild([{ path: '', component: AddLessonsComponent }]), CommonModule],
	declarations: [AddLessonsComponent]
})
export class AddLessonsModule {}
