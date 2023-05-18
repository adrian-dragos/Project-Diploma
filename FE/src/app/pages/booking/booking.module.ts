import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookingComponent } from './booking.component';
import { RouterModule } from '@angular/router';

@NgModule({
	declarations: [BookingComponent],
	imports: [CommonModule, RouterModule.forChild([{ path: '', component: BookingComponent }])]
})
export class BookingModule {}
