import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
	{ path: 'login', loadChildren: () => import('src/app/pages/login/login.module').then((m) => m.LoginModule) },
	{ path: 'register', loadChildren: () => import('src/app/pages/register/register.module').then((m) => m.RegisterModule) },
	{ path: '', loadChildren: () => import('src/app/layout/layout.module').then((m) => m.LayoutModule) },
	{ path: '**', loadChildren: () => import('src/app/pages/not-found/not-found.module').then((m) => m.NotFoundModule) }
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule]
})
export class AppRoutingModule {}
