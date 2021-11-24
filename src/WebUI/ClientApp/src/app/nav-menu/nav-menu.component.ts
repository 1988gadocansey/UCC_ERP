import {Component} from '@angular/core';
import {Observable} from "rxjs";
import {AuthorizeService} from "../../api-authorization/authorize.service";
import {map} from "rxjs/operators";

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.scss']
})
export class NavMenuComponent {
  isExpanded = false;
  public isAuthenticated: Observable<boolean>;
  collapse() {
    this.isExpanded = false;
  }
  constructor(private authorizeService: AuthorizeService) {
  }

  ngOnInit() {
    this.isAuthenticated = this.authorizeService.isAuthenticated();

  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
