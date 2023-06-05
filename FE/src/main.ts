import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';

platformBrowserDynamic()
	.bootstrapModule(AppModule)
	.catch((err) => console.error(err));

const name = 'Sarah Johnson';
const studentRole = 'student';
const adminRole = 'admin';
const instructorRole = 'instructor';
const studentId = '1';
const instructorId = '1';
localStorage.setItem('userRole', adminRole);
localStorage.setItem('userName', name);
// localStorage.setItem('userRole', instructorRole);
// localStorage.setItem('instructorId', instructorId);
localStorage.setItem('userRole', studentRole);
localStorage.setItem('studentId', studentId);
