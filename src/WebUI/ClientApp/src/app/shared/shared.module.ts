import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {HeaderComponent} from './header/header.component';
import {FooterComponent} from './footer/footer.component';
import {BackendlayoutComponent} from './backendlayout/backendlayout.component';
import {RouterModule} from "@angular/router";


@NgModule({
  declarations: [
    HeaderComponent,
    FooterComponent,
    BackendlayoutComponent,

  ],
  exports: [
    HeaderComponent,
    FooterComponent,
    BackendlayoutComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ]
})
export class SharedModule {
}
