import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { LoginUserRequestViewModel, UserTokenViewModel, UsersClient } from '@api/api:';
import { BehaviorSubject, Observable, map } from 'rxjs';

@Injectable({
	providedIn: 'root'
})
export class UserService {
	readonly JWT_TOKEN = 'JwtToken';
	private jwtTokenSubject: BehaviorSubject<string>;
	public jwtToken: Observable<string>;

	constructor(private readonly Client: UsersClient, private readonly router: Router) {
		this.jwtTokenSubject = new BehaviorSubject(localStorage.getItem(this.JWT_TOKEN));
		this.jwtToken = this.jwtTokenSubject.asObservable();
	}

	login(email: string, password: string): Observable<UserTokenViewModel> {
		const user: LoginUserRequestViewModel = { email, password };

		return this.Client.loginUser(user).pipe(
			map((tokenObject: UserTokenViewModel) => {
				localStorage.setItem(this.JWT_TOKEN, JSON.stringify(user));
				this.jwtTokenSubject.next(tokenObject.jwtToken);
				return tokenObject;
			})
		);
	}

	logout(): void {
		this.removeJwtToken();
	}

	removeJwtToken(): void {
		localStorage.removeItem(this.JWT_TOKEN);
		this.jwtTokenSubject.next(null);
		this.router.navigate(['/login']);
	}
}
