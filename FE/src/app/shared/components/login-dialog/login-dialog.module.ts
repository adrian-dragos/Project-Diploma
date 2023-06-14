import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginDialogComponent } from './login-dialog.component';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
	declarations: [LoginDialogComponent],
	imports: [CommonModule, MatButtonModule, MatDialogModule],
	exports: [LoginDialogComponent]
})
export class LoginDialogModule {}
