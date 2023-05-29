import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CancelDialogComponent } from './cancel-dialog.component';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
	declarations: [CancelDialogComponent],
	exports: [CancelDialogComponent],
	imports: [CommonModule, MatButtonModule, MatDialogModule]
})
export class CancelDialogModule {}
