import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { RouterModule } from '@angular/router';
import { MatButtonModule } from '@angular/material/button';
@NgModule({
	imports: [CommonModule, RouterModule.forChild([{ path: '', component: HomeComponent }]), MatButtonModule],
	declarations: [HomeComponent]
})
export class HomeModule {}
