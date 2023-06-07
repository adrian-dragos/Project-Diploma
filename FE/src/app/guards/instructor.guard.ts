import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';

@Injectable({
	providedIn: 'root'
})
export class InstructorGuard implements CanActivate {
	constructor(private readonly router: Router) {}

	async canActivate(): Promise<boolean> {
		const role = localStorage.getItem('userRole');
		console.log('InstructorGuard');
		console.log(role);
		if (role === 'instructor') {
			this.router.navigate(['/account']);
			return false;
		}

		return true;
	}
}
