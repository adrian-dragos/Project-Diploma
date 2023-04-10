import { NgModule } from '@angular/core';
import { LayoutComponent } from './layout.component';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { LayoutRoutingModule } from './layout-routing.module';

@NgModule({
	imports: [CommonModule, RouterModule, LayoutRoutingModule],
	declarations: [LayoutComponent],
	exports: [],
	providers: []
})
export class LayoutModule {}
