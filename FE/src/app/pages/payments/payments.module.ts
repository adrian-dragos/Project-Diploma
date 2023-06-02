import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaymentsComponent } from './payments.component';
import { RouterModule } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';
import { LoadingSpinnerModule } from '@app/shared/components/loading-spinner/loading-spinner.module';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';

@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([{ path: '', component: PaymentsComponent }]),
		MatIconModule,
		LoadingSpinnerModule,
		MatButtonModule,
		MatTableModule
	],
	declarations: [PaymentsComponent]
})
export class PaymentsModule {}
