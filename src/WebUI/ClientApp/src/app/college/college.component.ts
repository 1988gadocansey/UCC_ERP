import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {Component, OnInit} from "@angular/core";
import {v4 as uuidv4} from 'uuid';
import {CollegeClient, CreateCollegeCommand, PaginatedListOfCollegeDto, TodosVm,} from "../web-api-client";
import {HttpClient} from "@angular/common/http";
import {CollegeService} from "../services/CollegeService";
import {Observable} from "rxjs";

@Component({
  selector: 'app-college',
  templateUrl: './college.component.html',
  styleUrls: ['./college.component.scss']
})
export class CollegeComponent implements   OnInit{

  CollegeForm: FormGroup
  Name: string
  Submitted: boolean = false
  Status: string
  Colleges: any = []

  constructor(private formBuilder: FormBuilder, private collegeClient: CollegeClient, private httpClient: HttpClient, private collegeService: CollegeService) {
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

    this.collegeClient.create(<CreateCollegeCommand>{name: this.CollegeForm.get('Name').value, uuid: uuid}).subscribe(
      result => {
        this.Submitted = true
        this.Status = result.toString()
      },
      error => {
        let errors = JSON.parse("error is " + error.response);
      }
    );
  }

  ngOnInit() {
    this.collegeClient.getCollegeWithPagination(1, 1, 2).subscribe(data => {
      this.Colleges = data.items
    })
  }
}


