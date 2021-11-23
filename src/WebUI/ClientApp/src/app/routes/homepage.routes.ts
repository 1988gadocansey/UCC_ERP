import {Routes} from '@angular/router';
import {CounterComponent} from '../counter/counter.component';
import {FetchDataComponent} from '../fetch-data/fetch-data.component';
import {HomeComponent} from '../home/home.component';
import {NotFoundComponent} from "../not-found/not-found.component";
import {ServeErrorComponent} from "../serve-error/serve-error.component";


export const HomeRoutes: Routes = [

  {path: 'counter', component: CounterComponent},
  {path: 'fetch-data', component: FetchDataComponent},
  {path: '404', component: NotFoundComponent},
  {path: '500', component: ServeErrorComponent},
  {path: '', component: HomeComponent, pathMatch: 'full'},

];
