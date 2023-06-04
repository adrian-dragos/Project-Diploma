import { Component, OnInit, inject } from '@angular/core';
import { CarGear, StudentClient, StudentProfileViewModel } from '@api/api:';
import { TooltipConstants } from '@app/constants/tooltip.constants';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { delay, tap } from 'rxjs';

@Component({
	selector: 'app-account',
	templateUrl: './account.component.html',
	styleUrls: ['./account.component.scss']
})
@UntilDestroy()
export class AccountComponent implements OnInit {
	student: StudentProfileViewModel;
	studentClient = inject(StudentClient);
	isLoading = true;
	showDelayTooltip = TooltipConstants.SHOW_DELAY;

	ngOnInit(): void {
		this.studentClient
			.getStudentProfile(1)
			.pipe(
				delay(100),
				tap(() => (this.isLoading = true)),
				untilDestroyed(this)
			)
			.subscribe((student) => {
				this.student = student;
				this.isLoading = false;
			});
	}

	getGearTypeText(gearType: number): string {
		return CarGear[gearType];
	}
}
