import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';


import {CollegeComponent} from "./college.component";
import {ReactiveFormsModule} from "@angular/forms";
import {RouterModule} from "@angular/router";
import {CollegeRouteModule} from "./college.route.module";


@NgModule({
  declarations: [CollegeComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    CollegeRouteModule
  ]
})
export class CollegeModule {
}
