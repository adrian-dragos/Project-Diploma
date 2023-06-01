import { Injectable } from '@angular/core';
import { MatDialog, MatDialogConfig, MatDialogRef } from '@angular/material/dialog';

@Injectable()
export class DialogService {
	constructor(private dialog: MatDialog) {}

	openDialog(component: any, data: any): MatDialogRef<any> {
		const dialogConfig = new MatDialogConfig();
		dialogConfig.data = data;
		dialogConfig.autoFocus = false;

		return this.dialog.open(component, dialogConfig);
	}
}
