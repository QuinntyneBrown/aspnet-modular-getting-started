import { bootstrap } from 'angular2/platform/browser';
import { Component, provide } from 'angular2/core';
import { Http, HTTP_BINDINGS } from 'angular2/http';
import { Route, Redirect, ROUTER_DIRECTIVES, ROUTER_PROVIDERS, APP_BASE_HREF, RouteConfig, LocationStrategy, HashLocationStrategy} from 'angular2/router';
import { HomeComponent } from './home.component';
import { AllPlayersComponent } from './all-players.component';
import { PlayerComponent } from './player.component';
import { AppHeaderComponent } from './app-header.component';
import { FooterComponent } from './footer.component';


@Component({
    selector: "app",
    templateUrl: '/wwwroot/components/app.component.html',
    directives: [ROUTER_DIRECTIVES, AppHeaderComponent, FooterComponent]
})
@RouteConfig([
    { path: '/home', name: 'Home', component: HomeComponent, useAsDefault: true },
    { path: '/players', name: 'Players', component: AllPlayersComponent },
    { path: '/player/:id', name: 'PlayerDetail', component: PlayerComponent }
])
class AppComponent {
    constructor() {

    }
}

bootstrap(AppComponent, [
    ROUTER_PROVIDERS,
    HTTP_BINDINGS,
    provide(LocationStrategy, { useClass: HashLocationStrategy })
]);