import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FaqComponent } from './faq.component';
import { MatExpansionModule } from '@angular/material/expansion';

@NgModule({
	imports: [CommonModule, RouterModule.forChild([{ path: '', component: FaqComponent }]), MatExpansionModule],
	declarations: [FaqComponent]
})
export class FaqModule {}
