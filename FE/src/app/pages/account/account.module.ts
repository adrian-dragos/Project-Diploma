import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccountComponent } from './account.component';
import { RouterModule, Routes } from '@angular/router';
import { EditAccountComponent } from './edit-account/edit-account.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { StudentClient } from '@api/api:';
import { DatePipe } from '@angular/common';
import { MatSelectModule } from '@angular/material/select';
import { LoadingSpinnerModule } from '@app/shared/components/loading-spinner/loading-spinner.module';
import { CancelDialogModule } from '@app/shared/components/cancel-dialog/cancel-dialog.module';

const routes: Routes = [
	{
		path: '',
		component: AccountComponent
	},
	{
		path: 'edit',
		component: EditAccountComponent
	}
];

@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild(routes),
		MatIconModule,
		DatePipe,
		MatButtonModule,
		ReactiveFormsModule,
		MatFormFieldModule,
		MatSelectModule,
		MatInputModule,
		LoadingSpinnerModule,
		CancelDialogModule
	],
	declarations: [AccountComponent, EditAccountComponent],
	providers: [StudentClient]
})
export class AccountModule {}
