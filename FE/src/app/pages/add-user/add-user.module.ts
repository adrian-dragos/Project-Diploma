import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddUserComponent } from './add-user.component';
import { RouterModule } from '@angular/router';
import { MatFormFieldModule } from '@angular/material/form-field';
import { ReactiveFormsModule } from '@angular/forms';
import { MatCardModule } from '@angular/material/card';
import { MatSelectModule } from '@angular/material/select';
import { MatButtonModule } from '@angular/material/button';
import { SnackBarService } from '@app/services/snack-bar.service';
import { MatInputModule } from '@angular/material/input';
import { UsersClient } from '@api/api:';

@NgModule({
	imports: [
		RouterModule.forChild([{ path: '', component: AddUserComponent }]),
		CommonModule,
		ReactiveFormsModule,
		MatFormFieldModule,
		MatCardModule,
		MatSelectModule,
		MatButtonModule,
		MatButtonModule,
		ReactiveFormsModule,
		MatFormFieldModule,
		MatSelectModule,
		MatInputModule
	],
	declarations: [AddUserComponent],
	providers: [SnackBarService, UsersClient]
})
export class AddUserModule {}
