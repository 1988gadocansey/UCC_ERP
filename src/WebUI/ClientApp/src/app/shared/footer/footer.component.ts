import {Component, OnInit} from '@angular/core';
import {getFullYear} from "ngx-bootstrap";

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.scss']
})
export class FooterComponent implements OnInit {
 copyRight: number;
  constructor() {
  }

  ngOnInit(): void {
    this.copyRight =new Date().getFullYear();
  }

}
