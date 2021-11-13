import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CollegeRoutingModule } from './college-routing.module';
import {CollegeComponent} from "./college.component";
import {ReactiveFormsModule} from "@angular/forms";


@NgModule({
  declarations: [CollegeComponent],
  imports: [
    CommonModule,
    CollegeRoutingModule,
    ReactiveFormsModule
  ]
})
export class CollegeModule { }
