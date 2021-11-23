import {NgModule} from '@angular/core';
import {Routes,RouterModule} from '@angular/router';
import {BackendRoutes} from "./routes/backend.routes";
import {HomeRoutes} from "./routes/homepage.routes";
import {PublicComponent} from "./public/public.component";
import {BackendlayoutComponent} from "./shared/backendlayout/backendlayout.component";

const routes: Routes = [
  {path:"",component:PublicComponent,children:HomeRoutes},
  {path:"app",component:BackendlayoutComponent,children:BackendRoutes},
  {path:"**", redirectTo:"404"}
];
@NgModule({
  imports: [RouterModule.forRoot(routes, {relativeLinkResolution: 'legacy'})],
  exports: [RouterModule],
})
export class AppRoutingModule {
}
