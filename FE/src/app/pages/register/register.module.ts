import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register.component';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { UserValidator } from '@app/validators/user.validator';
import { RegisterSuccessfulComponent } from './register-successful/register-successful.component';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';
@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([
			{ path: '', component: RegisterComponent },
			{ path: 'success', component: RegisterSuccessfulComponent }
		]),
		ReactiveFormsModule,
		MatCardModule,
		MatButtonModule,
		MatInputModule,
		MatIconModule,
		MatTooltipModule
	],
	declarations: [RegisterComponent, RegisterSuccessfulComponent],
	providers: [UserValidator]
})
export class RegisterModule {}
