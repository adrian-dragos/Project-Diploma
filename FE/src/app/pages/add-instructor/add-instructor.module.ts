import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddInstructorComponent } from './add-instructor.component';
import { RouterModule } from '@angular/router';

@NgModule({
	imports: [RouterModule.forChild([{ path: '', component: AddInstructorComponent }]), CommonModule],
	declarations: [AddInstructorComponent]
})
export class AddInstructorModule {}
