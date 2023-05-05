import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RouterModule, Routes } from '@angular/router';

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
	imports: [BrowserModule, AppRoutingModule, RouterModule.forRoot(routes)],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
