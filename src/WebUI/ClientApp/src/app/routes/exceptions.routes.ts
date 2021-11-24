import {Routes} from '@angular/router';
export const ExceptionsRoutes: Routes = [
  {
    path: "400",
    loadChildren: () => import("../exceptions/exceptions.module").then(d => d.ExceptionsModule)
  },

];
