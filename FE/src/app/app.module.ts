import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { UsersClient } from '@api/api:';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { UnauthorizedInterceptor } from './interceptors/unauthorized.interceptor';
import { MatTableModule } from '@angular/material/table';

@NgModule({
	declarations: [AppComponent],
	imports: [BrowserModule, AppRoutingModule, BrowserAnimationsModule, MatSnackBarModule, HttpClientModule, MatTableModule],
	providers: [UsersClient, MatSnackBarModule, { provide: HTTP_INTERCEPTORS, useClass: UnauthorizedInterceptor, multi: true }],
	bootstrap: [AppComponent]
})
export class AppModule {}
