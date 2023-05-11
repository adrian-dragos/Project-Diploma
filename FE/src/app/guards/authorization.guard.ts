import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';

@Injectable({
	providedIn: 'root'
})
export class AuthorizationGuard implements CanActivate {
	readonly JWT_TOKEN = 'JwtToken';
	constructor(private readonly router: Router) {}

	async canActivate(): Promise<boolean> {
		const token = localStorage.getItem(this.JWT_TOKEN);
		if (!token) {
			this.router.navigate(['/login']);
			return false;
		}

		return true;
	}
}
