import { Component, EventEmitter, Output, inject } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { UserService } from '@app/services/user.service';
import { LogoutDialogComponent } from './logout-dialog/logout-dialog.component';

@Component({
	selector: 'app-header',
	templateUrl: './header.component.html',
	styleUrls: ['./header.component.scss']
})
export class HeaderComponent {
	@Output() toggleSidebarForMe: EventEmitter<any> = new EventEmitter();

	userService = inject(UserService);

	constructor(private readonly router: Router, private readonly dialog: MatDialog) {}

	openLogoutDialog(): void {
		console.log('openLogoutDialog');
		const dialogRef = this.dialog.open(LogoutDialogComponent, {
			width: '300px',
			autoFocus: false
		});

		dialogRef.afterClosed().subscribe((result) => {
			if (result) {
				this.router.navigate(['/login']);
			}
		});
	}

	toggleSidebar(): void {
		this.toggleSidebarForMe.emit();
	}
}
