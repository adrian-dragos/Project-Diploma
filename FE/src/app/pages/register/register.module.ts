import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register.component';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([{ path: '', component: RegisterComponent }]),
		ReactiveFormsModule,
		MatCardModule,
		MatButtonModule,
		MatInputModule
	],
	declarations: [RegisterComponent]
})
export class RegisterModule {}
