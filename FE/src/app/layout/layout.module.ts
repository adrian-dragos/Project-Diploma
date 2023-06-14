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
import { MatButtonModule } from '@angular/material/button';
import { UsersClient } from '@api/api:';
import { NotInstructorGuard } from '@app/guards/instructor.guard';
import { LoadingSpinnerModule } from '@app/shared/components/loading-spinner/loading-spinner.module';
import { NotStudentGuard } from '@app/guards/student.guard';

const routes: Routes = [
	{
		path: '',
		canActivate: [AuthorizationGuard],
		component: LayoutComponent,
		children: [
			{ path: 'lessons', loadChildren: () => import('src/app/pages/lessons/lessons.module').then((m) => m.LessonsModule) },
			{ path: 'account', loadChildren: () => import('src/app/pages/account/account.module').then((m) => m.AccountModule) },
			{
				path: 'payments',
				canActivate: [NotInstructorGuard],
				loadChildren: () => import('src/app/pages/payments/payments.module').then((m) => m.PaymentsModule)
			},
			{
				path: 'booking',
				canActivate: [NotInstructorGuard],
				loadChildren: () => import('src/app/pages/booking/booking.module').then((m) => m.BookingModule)
			},
			{
				path: 'add-lessons',
				canActivate: [NotStudentGuard],
				loadChildren: () => import('src/app/pages/add-lessons/add-lessons.module').then((m) => m.AddLessonsModule)
			},
			{
				path: 'add-instructors',
				canActivate: [NotStudentGuard, NotInstructorGuard],
				loadChildren: () => import('src/app/pages/add-instructor/add-instructor.module').then((m) => m.AddInstructorModule)
			},
			{ path: '', redirectTo: 'booking', pathMatch: 'full' }
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
		MatButtonModule,
		LoadingSpinnerModule
	],
	declarations: [LayoutComponent, HeaderComponent, SidebarComponent, LogoutDialogComponent],
	exports: [],
	providers: [UsersClient]
})
export class LayoutModule {}
