import { Component } from 'angular2/core';
import { RouterLink } from 'angular2/router';

@Component({
    selector: 'app-header',
    templateUrl: 'wwwroot/components/app-header.component.html',
    styleUrls: ['wwwroot/components/app-header.component.css'],
    directives: [RouterLink]
})
export class AppHeaderComponent {

}