import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { LoginComponent } from './login.component';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatIconModule } from '@angular/material/icon';
import { UsersClient } from '@api/api:';

@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([{ path: '', component: LoginComponent }]),
		ReactiveFormsModule,
		ReactiveFormsModule,
		MatCardModule,
		MatButtonModule,
		MatInputModule,
		MatTooltipModule,
		MatIconModule
	],
	declarations: [LoginComponent],
	providers: [UsersClient]
})
export class LoginModule {}
