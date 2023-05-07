import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { Client } from '@api/api:';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { UnauthorizedInterceptor } from './interceptors/unauthorized.interceptor';

const routes: Routes = [
	{
		path: 'login',
		loadChildren: () => import('./pages/login/login.module').then((m) => m.LoginModule)
	},
	{
		path: 'register',
		loadChildren: () => import('./pages/register/register.module').then((m) => m.RegisterModule)
	},
	{
		path: '',
		loadChildren: () => import('./layout/layout.module').then((m) => m.LayoutModule)
	}
];

@NgModule({
	declarations: [AppComponent],
	imports: [BrowserModule, AppRoutingModule, RouterModule.forRoot(routes), BrowserAnimationsModule, MatSnackBarModule, HttpClientModule],
	providers: [Client, MatSnackBarModule, { provide: HTTP_INTERCEPTORS, useClass: UnauthorizedInterceptor, multi: true }],
	bootstrap: [AppComponent]
})
export class AppModule {}
