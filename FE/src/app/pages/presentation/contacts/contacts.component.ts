import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Observable, catchError, map, of, tap } from 'rxjs';

@Component({
	selector: 'app-contacts',
	templateUrl: './contacts.component.html',
	styleUrls: ['./contacts.component.scss']
})
export class ContactsComponent {
	apiLoaded: Observable<boolean>;

	schoolLocation: google.maps.LatLngLiteral = {
		lat: 45.746373685026256,
		lng: 21.24781613107098
	};
	zoom = 15;
	markerOptions: google.maps.MarkerOptions = { draggable: false };

	mapOptions: google.maps.MapOptions = {
		minZoom: 12,
		maxZoom: 19,
		streetViewControl: false
	};

	constructor(httpClient: HttpClient) {
		this.apiLoaded = httpClient
			.jsonp('https://maps.googleapis.com/maps/api/js?key=AIzaSyBAXM3kLgdcWR7xVtxGiB90kgB-8_DXAqI', 'callback')
			.pipe(
				tap((x) => console.log('Google Maps API loaded' + x)),
				map(() => true),
				catchError(() => of(false))
			);
	}
}
