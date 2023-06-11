import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PresentationComponent } from './presentation.component';
import { RouterModule, Routes } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';

const routes: Routes = [
	{
		path: '',
		component: PresentationComponent,
		children: [
			{ path: 'home', loadChildren: () => import('./home/home.module').then((m) => m.HomeModule) },
			{ path: 'booking', loadChildren: () => import('../booking/booking.module').then((m) => m.BookingModule) },
			{ path: 'contacts', loadChildren: () => import('./contacts/contacts.module').then((m) => m.ContactsModule) },
			{ path: 'about-us', loadChildren: () => import('./about-us/about-us.module').then((m) => m.AboutUsModule) },
			{ path: 'faq', loadChildren: () => import('./faq/faq.module').then((m) => m.FaqModule) }
		]
	}
];

@NgModule({
	imports: [CommonModule, RouterModule.forChild(routes), MatToolbarModule, MatSidenavModule, MatListModule, MatButtonModule, MatIconModule],
	declarations: [PresentationComponent, NavbarComponent]
})
export class PresentationModule {}
