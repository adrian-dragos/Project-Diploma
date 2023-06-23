import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContactsComponent } from './contacts.component';
import { RouterModule } from '@angular/router';
import { GoogleMapsModule } from '@angular/google-maps';
import { MatIconModule } from '@angular/material/icon';

@NgModule({
	imports: [CommonModule, RouterModule.forChild([{ path: '', component: ContactsComponent }]), GoogleMapsModule, MatIconModule],
	declarations: [ContactsComponent]
})
export class ContactsModule {}
