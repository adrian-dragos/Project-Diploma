import { NgModule } from '@angular/core';
import { LayoutComponent } from './layout.component';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { LayoutRoutingModule } from './layout-routing.module';
import { HeaderComponent } from './header/header.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { MatIconModule } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatMenuModule } from '@angular/material/menu';
import { MatDividerModule } from '@angular/material/divider';
import { MatListModule } from '@angular/material/list';
import { MatDialogModule } from '@angular/material/dialog';
import { AuthorizationGuard } from '@app/guards/authorization.guard';
import { LogoutDialogComponent } from './header/logout-dialog/logout-dialog.component';
import { MatButton, MatButtonModule } from '@angular/material/button';

const routes: Routes = [
	{
		path: '',
		canActivate: [AuthorizationGuard],
		component: LayoutComponent,
		children: [
			{ path: '', redirectTo: 'home', pathMatch: 'full' },
			{ path: 'home', loadChildren: () => import('src/app/pages/home/home.module').then((m) => m.HomeModule) },
			{ path: 'lessons', loadChildren: () => import('src/app/pages/lessons/lessons.module').then((m) => m.LessonsModule) }
		]
	}
];

@NgModule({
	imports: [
		CommonModule,
		RouterModule,
		LayoutRoutingModule,
		RouterModule.forChild(routes),
		MatIconModule,
		MatToolbarModule,
		MatListModule,
		MatSidenavModule,
		MatMenuModule,
		MatDividerModule,
		MatDialogModule,
		MatButtonModule
	],
	declarations: [LayoutComponent, HeaderComponent, SidebarComponent, LogoutDialogComponent],
	exports: [],
	providers: []
})
export class LayoutModule {}
