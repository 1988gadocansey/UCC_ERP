import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';


import {CollegeComponent} from "./college.component";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {RouterModule} from "@angular/router";
import {CollegeRouteModule} from "./college.route.module";
import {FontAwesomeModule} from "@fortawesome/angular-fontawesome";
import {PaginationModule} from "ngx-bootstrap";
import {SweetAlert2Module} from "@sweetalert2/ngx-sweetalert2";


@NgModule({
  declarations: [CollegeComponent],
    imports: [
        CommonModule,
        ReactiveFormsModule,
        CollegeRouteModule,
        FontAwesomeModule,
        PaginationModule,
        SweetAlert2Module,
        FormsModule
    ]
})
export class CollegeModule {
}
