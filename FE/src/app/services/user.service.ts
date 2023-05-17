import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { LoginUserRequestViewModel, UserTokenViewModel, UsersClient } from '@api/api:';
import { Observable, map } from 'rxjs';

@Injectable({
	providedIn: 'root'
})
export class UserService {
	readonly JWT_TOKEN = 'JwtToken';

	constructor(private readonly Client: UsersClient, private readonly router: Router) {}

	login(email: string, password: string): Observable<UserTokenViewModel> {
		const user: LoginUserRequestViewModel = { email, password };

		return this.Client.loginUser(user).pipe(
			map((tokenObject: UserTokenViewModel) => {
				localStorage.setItem(this.JWT_TOKEN, JSON.stringify(user));
				return tokenObject;
			})
		);
	}

	removeJwtToken(): void {
		localStorage.removeItem(this.JWT_TOKEN);
		this.router.navigate(['/login']);
	}
}
