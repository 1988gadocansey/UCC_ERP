import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {FetchDataComponent} from "../fetch-data/fetch-data.component";
import {CollegeComponent} from "./college.component";

const routes: Routes = [ { path: 'college', component: CollegeComponent },];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CollegeRoutingModule { }
