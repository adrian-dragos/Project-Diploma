import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AccountComponent } from './account.component';
import { RouterModule, Routes } from '@angular/router';
import { EditAccountComponent } from './edit-account/edit-account.component';

const routes: Routes = [
	{
		path: '',
		component: AccountComponent,
		children: [
			{ path: '', redirectTo: 'account', pathMatch: 'full' },
			{ path: 'edit', component: EditAccountComponent }
		]
	}
];

@NgModule({
	declarations: [AccountComponent, EditAccountComponent],
	imports: [CommonModule, RouterModule.forChild(routes)]
})
export class AccountModule {}
