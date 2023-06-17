import { Component, OnInit, inject } from '@angular/core';
import { UsersClient } from '@api/api:';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { tap } from 'rxjs';

@Component({
	selector: 'app-layout',
	templateUrl: './layout.component.html',
	styleUrls: ['./layout.component.scss']
})
@UntilDestroy()
export class LayoutComponent implements OnInit {
	isSideBarOpened = true;
	isLoading = true;

	userClient = inject(UsersClient);

	ngOnInit(): void {
		this.userClient
			.getUserDetails()
			.pipe(
				tap(() => (this.isLoading = true)),
				untilDestroyed(this)
			)
			.subscribe((user) => {
				localStorage.setItem('userRole', user.role);
				localStorage.setItem('userId', user.id.toString());
				this.isLoading = false;
				console.log(user);
			});
	}

	toggleSideBar(): void {
		this.isSideBarOpened = !this.isSideBarOpened;
	}
}
