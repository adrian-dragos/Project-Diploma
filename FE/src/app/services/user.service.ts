import { Injectable, inject } from '@angular/core';
import { Router } from '@angular/router';
import { LoginUserRequestViewModel, UserTokenViewModel, UsersClient } from '@api/api:';
import { Observable, map, tap } from 'rxjs';

@Injectable({
	providedIn: 'root'
})
export class UserService {
	readonly JWT_TOKEN = 'JwtToken';

	userClient = inject(UsersClient);
	constructor(private readonly router: Router) {}

	login(email: string, password: string): Observable<UserTokenViewModel> {
		const user: LoginUserRequestViewModel = { email, password };
		localStorage.clear();

		return this.userClient.loginUser(user).pipe(
			map((tokenObject: UserTokenViewModel) => {
				localStorage.setItem(this.JWT_TOKEN, tokenObject.jwtToken);
				return tokenObject;
			})
		);
	}

	removeJwtToken(): void {
		localStorage.clear();
		this.router.navigate(['/login']);
	}
}
