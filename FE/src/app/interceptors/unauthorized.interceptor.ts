import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable, NgZone } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, Observer, catchError, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable()
export class UnauthorizedInterceptor implements HttpInterceptor {
	constructor(private router: Router, private ngZone: NgZone) {}

	intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
		const userToken = localStorage.getItem('JwtToken');
		request = request.clone({
			setHeaders: {
				Authorization: `Bearer ${userToken}`
			}
		});

		if (environment.production === true) {
			request = request.clone({ url: environment.apiUrl + request.url });
		}

		return this.ngZone.run(() => {
			return next.handle(request).pipe(
				enterZone(this.ngZone),
				catchError((error: any) => {
					if (error instanceof HttpErrorResponse && error.status === 401) {
						this.router.navigate(['/login']);
					}
					return throwError(error);
				})
			);
		});
	}
}

export function enterZone<T>(zone: NgZone): (source: Observable<T>) => Observable<T> {
	return (source: Observable<T>) => {
		return new Observable((sink: Observer<T>) => {
			return source.subscribe({
				next(x: T): void {
					zone.run(() => sink.next(x));
				},
				error(e: T): void {
					zone.run(() => sink.error(e));
				},
				complete(): void {
					zone.run(() => sink.complete());
				}
			});
		});
	};
}
