import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { UsersClient } from '@api/api:';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { UnauthorizedInterceptor } from './interceptors/unauthorized.interceptor';
import { LessonsComponent } from './pages/lessons/lessons.component';

@NgModule({
	declarations: [AppComponent, LessonsComponent],
	imports: [BrowserModule, AppRoutingModule, BrowserAnimationsModule, MatSnackBarModule, HttpClientModule],
	providers: [UsersClient, MatSnackBarModule, { provide: HTTP_INTERCEPTORS, useClass: UnauthorizedInterceptor, multi: true }],
	bootstrap: [AppComponent]
})
export class AppModule {}
