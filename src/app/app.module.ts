import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LayoutComponent } from './layout/layout.component';
import { RouterModule, Routes } from '@angular/router';

const appRoutes: Routes = [
	{
		path: '',
		loadChildren: () => import('./layout/layout.module').then((m) => m.LayoutModule)
	}
];

@NgModule({
	declarations: [AppComponent, LayoutComponent],
	imports: [BrowserModule, AppRoutingModule, RouterModule.forRoot(appRoutes)],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {}
