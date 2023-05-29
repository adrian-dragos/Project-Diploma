import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { LayoutComponent } from './layout.component';

const appRoutes = [
	{
		path: '',
		component: LayoutComponent
	}
];

@NgModule({
	imports: [RouterModule.forChild(appRoutes)],
	exports: [RouterModule]
})
export class LayoutRoutingModule {}
