import {Component, OnInit} from '@angular/core';
import {Observable} from "rxjs";
import {AuthorizeService} from "../../../api-authorization/authorize.service";

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent   {

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
