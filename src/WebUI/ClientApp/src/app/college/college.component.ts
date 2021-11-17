import {FormBuilder, FormGroup, FormsModule, Validators} from "@angular/forms";
import {ReactiveFormsModule} from "@angular/forms";
import {Component, OnInit} from "@angular/core";
import {v4 as uuidv4} from 'uuid';
import {
  CollegeClient,
  CreateCollegeCommand, WeatherForecast,
} from "../web-api-client";
import {HttpClient, HttpHeaders, HttpResponseBase} from "@angular/common/http";
import {mergeMap as _observableMergeMap} from "rxjs/operators";
import {catchError as _observableCatch} from "rxjs/internal/operators/catchError";
import {Observable} from "rxjs";
import {throwError as _observableThrow} from "rxjs/internal/observable/throwError";

@Component({
  selector: 'app-college',
  templateUrl: './college.component.html',
  styleUrls: ['./college.component.css']
})
export class CollegeComponent {
  CollegeForm: FormGroup
  Name: string
  Submitted: boolean = false
  Status: string
  constructor(private formBuilder: FormBuilder, private collegeClient: CollegeClient, private httpClient: HttpClient) {
    this.CollegeForm = this.formBuilder.group({
      Name: ['', [Validators.required]],
    })
  }

  submit() {
    console.log("data submitted to server")
    const uuid = uuidv4();
    const body = {
      'Name': this.CollegeForm.get('Name').value,
      'Uuid': uuid
    }

    this.collegeClient.create(<CreateCollegeCommand>{name: this.CollegeForm.get('Name').value,uuid: uuid}).subscribe(
      result => {
        this.Submitted=true
        this.Status=result.toString()
      },
      error => {
        let errors = JSON.parse("error is "+error.response);
      }
    );

  }
}
