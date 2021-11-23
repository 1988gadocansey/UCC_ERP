import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {Component} from "@angular/core";
import {v4 as uuidv4} from 'uuid';
import {CollegeClient, CreateCollegeCommand,} from "../web-api-client";
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-college',
  templateUrl: './college.component.html',
  styleUrls: ['./college.component.scss']
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
}
