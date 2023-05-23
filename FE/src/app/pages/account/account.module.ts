import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccountComponent } from './account.component';
import { RouterModule, Routes } from '@angular/router';
import { EditAccountComponent } from './edit-account/edit-account.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';

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
	declarations: [AccountComponent, EditAccountComponent],
	imports: [CommonModule, RouterModule.forChild(routes), MatIconModule, MatButtonModule]
})
export class AccountModule {}
