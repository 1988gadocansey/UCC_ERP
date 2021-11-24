import {NgModule} from '@angular/core';
import {Routes,RouterModule} from '@angular/router';
import {BackendRoutes} from "./routes/backend.routes";
import {HomeRoutes} from "./routes/homepage.routes";
import {PublicComponent} from "./public/public.component";
import {BackendlayoutComponent} from "./shared/backendlayout/backendlayout.component";
import {NotfoundComponent} from "./exceptions/notfound/notfound.component";
import {ExceptionsRoutes} from "./routes/exceptions.routes";

const routes: Routes = [
  {path:"",component:PublicComponent,children:HomeRoutes},
  {path:"app",component:BackendlayoutComponent,children:BackendRoutes},
  {path:"**", component:NotfoundComponent,children:ExceptionsRoutes}
];
@NgModule({
  imports: [RouterModule.forRoot(routes, {relativeLinkResolution: 'legacy'})],
  exports: [RouterModule],
})
export class AppRoutingModule {
}
