import { Component, EventEmitter, OnInit, Output, inject } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { UserService } from '@app/services/user.service';
import { LogoutDialogComponent } from './logout-dialog/logout-dialog.component';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { UsersClient } from '@api/api:';

@Component({
	selector: 'app-header',
	templateUrl: './header.component.html',
	styleUrls: ['./header.component.scss']
})
@UntilDestroy()
export class HeaderComponent implements OnInit {
	@Output() toggleSidebarForMe: EventEmitter<any> = new EventEmitter();

	userName: string;
	role: string;

	userService = inject(UserService);
	usersClient = inject(UsersClient);

	constructor(private readonly router: Router, private readonly dialog: MatDialog) {}

	ngOnInit(): void {
		this.usersClient.getUserShortProfile().subscribe((user) => {
			this.userName = user.fullName;
			localStorage.setItem('userName', this.userName);
		});
		this.role = localStorage.getItem('userRole');
	}

	openLogoutDialog(): void {
		const dialogRef = this.dialog.open(LogoutDialogComponent, {
			width: '300px',
			autoFocus: false
		});

		dialogRef
			.afterClosed()
			.pipe(untilDestroyed(this))
			.subscribe((result) => {
				if (result) {
					this.router.navigate(['/login']);
				}
			});
	}

	toggleSidebar(): void {
		this.toggleSidebarForMe.emit();
	}
}
