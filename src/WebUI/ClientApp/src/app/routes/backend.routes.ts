import {Routes} from "@angular/router";
import {TodoComponent} from '../todo/todo.component';
import {TokenComponent} from '../token/token.component';
import {AuthorizeGuard} from "../../api-authorization/authorize.guard";

export const BackendRoutes: Routes = [
  {
    path: "college",
    loadChildren: () => import("../college/college.module").then(c => c.CollegeModule)
  },
  {
    path: "dashboard",
    loadChildren: () => import("../dashboard/dashboard.module").then(d => d.DashboardModule)
  },

  {path: 'todo', component: TodoComponent, canActivate: [AuthorizeGuard]},
  {path: 'token', component: TokenComponent, canActivate: [AuthorizeGuard]}
]


