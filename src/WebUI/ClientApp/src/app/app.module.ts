import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
import {FontAwesomeModule} from '@fortawesome/angular-fontawesome';

import {AppComponent} from './app.component';
import {NavMenuComponent} from './nav-menu/nav-menu.component';
import {HomeComponent} from './home/home.component';
import {CounterComponent} from './counter/counter.component';
import {FetchDataComponent} from './fetch-data/fetch-data.component';
import {TodoComponent} from './todo/todo.component';
import {ApiAuthorizationModule} from 'src/api-authorization/api-authorization.module';
import {AuthorizeInterceptor} from 'src/api-authorization/authorize.interceptor';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {ModalModule} from 'ngx-bootstrap/modal';
import {AppRoutingModule} from './app-routing.module';
import {TokenComponent} from './token/token.component';
import {CollegeModule} from "./college/college.module";

import {StudentComponent} from './student/student.component';
import {DashboardModule} from "./dashboard/dashboard.module";
import { PublicComponent } from './public/public.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { ServeErrorComponent } from './serve-error/serve-error.component';
import { MaintenaceComponent } from './maintenace/maintenace.component';
import {SharedModule} from "./shared/shared.module";


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    TodoComponent,
    TokenComponent,

    StudentComponent,
      PublicComponent,


  ],
  imports: [
    BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
    FontAwesomeModule,
    HttpClientModule,
    FormsModule,
    SharedModule,

    ApiAuthorizationModule,
    AppRoutingModule,
    BrowserAnimationsModule,

    ModalModule.forRoot()
  ],
  providers: [
    {provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true},
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
