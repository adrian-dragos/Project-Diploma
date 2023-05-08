import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { LoginComponent } from './login.component';

@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([{ path: '', component: LoginComponent }]),
		ReactiveFormsModule,
		ReactiveFormsModule,
		MatCardModule,
		MatButtonModule,
		MatInputModule
	],
	declarations: [LoginComponent]
})
export class LoginModule {}
