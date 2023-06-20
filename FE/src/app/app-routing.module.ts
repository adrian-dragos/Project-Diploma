import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthorizationGuard } from './guards/authorization.guard';

const routes: Routes = [
	{ path: 'login', loadChildren: () => import('src/app/pages/login/login.module').then((m) => m.LoginModule) },
	{ path: 'register', loadChildren: () => import('src/app/pages/register/register.module').then((m) => m.RegisterModule) },
	{
		path: 'app',
		canActivate: [AuthorizationGuard],
		loadChildren: () => import('src/app/layout/layout.module').then((m) => m.LayoutModule)
	},
	{
		path: 'new-profile',
		canActivate: [AuthorizationGuard],
		loadChildren: () => import('src/app/pages/add-new-profile/add-new-profile.module').then((m) => m.AddNewProfileModule)
	},
	{
		path: 'app/payment',
		loadChildren: () => import('@app/pages/card-payment/card-payment.module').then((m) => m.default)
	},
	{
		path: '',
		loadChildren: () => import('@app/pages/presentation/presentation.module').then((m) => m.PresentationModule)
	},
	{ path: '**', loadChildren: () => import('src/app/pages/not-found/not-found.module').then((m) => m.NotFoundModule) }
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
})
export class AppRoutingModule {}
