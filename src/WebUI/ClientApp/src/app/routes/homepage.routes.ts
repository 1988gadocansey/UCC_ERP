import {Routes} from '@angular/router';
import {CounterComponent} from '../counter/counter.component';
import {FetchDataComponent} from '../fetch-data/fetch-data.component';
import {HomeComponent} from '../home/home.component';



export const HomeRoutes: Routes = [

  {path: 'counter', component: CounterComponent},
  {path: 'fetch-data', component: FetchDataComponent},
  {path: '', component: HomeComponent, pathMatch: 'full'},

];
