import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';

import {CollegeComponent} from "./college.component";
import {HeaderComponent} from "../shared/header/header.component";
import {FooterComponent} from "../shared/footer/footer.component";
import {BackendlayoutComponent} from "../shared/backendlayout/backendlayout.component";
import {ViewComponent} from "./view/view.component";

const routes: Routes = [
  {path: '', component: CollegeComponent},

];

@NgModule({
  declarations: [
    ViewComponent,
  ],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CollegeRouteModule {
}
