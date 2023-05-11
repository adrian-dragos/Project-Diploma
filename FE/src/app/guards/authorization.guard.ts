import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';

@Injectable({
	providedIn: 'root'
})
export class AuthorizationGuard implements CanActivate {
	constructor(private readonly router: Router) {}

	async canActivate(): Promise<boolean> {
		return true;
	}
}
