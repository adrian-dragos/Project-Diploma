import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContactsComponent } from './contacts.component';
import { RouterModule } from '@angular/router';

@NgModule({
	imports: [CommonModule, RouterModule.forChild([{ path: '', component: ContactsComponent }])],
	declarations: [ContactsComponent]
})
export class ContactsModule {}
