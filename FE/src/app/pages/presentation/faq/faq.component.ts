import { Component } from '@angular/core';
import { Faq } from '@app/models/faq.model';

@Component({
	selector: 'app-faq',
	templateUrl: './faq.component.html',
	styleUrls: ['./faq.component.scss']
})
export class FaqComponent {
	faqs: Faq[] = [
		{
			question: 'Who was this website developed by?',
			answer: 'This website was developed Adrian Dragoș.'
		},
		{
			question: 'Who is Adrian Dragoș?',
			answer:
				'At the moment of writing this, Adrian Dragoș is a 4th year student at the Faculty of Automatic and Computer Science, Politehnica University of Timișoara' +
				'He is also a junior software developer at Amdaris SRL Romania.'
		},
		{
			question: 'Why this website was created?',
			answer:
				"This website was created as a project for my bachelor's degree. I desinged a presentation website for a driving school and a web app for the same driving school."
		},
		{
			question: 'What is this website about?',
			answer:
				'This website is a presentation website for driving school. It helps students to find with ease available driving lessons, and facilitating the booking and payment process'
		},
		{
			question: 'What technologies were used to develop this website?',
			answer:
				'This website was developed using Angular 15 with Typescript 4.9.0, Angular Material and Google Maps API.' +
				'The server was developed using .NET Core 6.0. The database was developed using Microsoft SQL Server 2019.'
		}
	];
}
