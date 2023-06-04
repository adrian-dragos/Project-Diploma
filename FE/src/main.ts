import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';

platformBrowserDynamic()
	.bootstrapModule(AppModule)
	.catch((err) => console.error(err));

const name = 'Sarah Johnson';
const role = 'student';
localStorage.setItem('userName', name);
localStorage.setItem('userRole', role);
