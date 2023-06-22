import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddNewProfileComponent } from './add-new-profile.component';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { StudentClient, UsersClient } from '@api/api:';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';

@NgModule({
	imports: [
		RouterModule.forChild([{ path: '', component: AddNewProfileComponent }]),
		CommonModule,
		ReactiveFormsModule,
		MatFormFieldModule,
		MatInputModule,
		MatToolbarModule,
		MatButtonModule,
		MatIconModule,
		MatDatepickerModule,
		MatNativeDateModule,
		MatSelectModule
	],
	declarations: [AddNewProfileComponent],
	providers: [StudentClient, UsersClient]
})
export class AddNewProfileModule {}
