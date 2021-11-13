import {FormBuilder, FormGroup, FormsModule, Validators} from "@angular/forms";
import {ReactiveFormsModule} from "@angular/forms";
import {Component, OnInit} from "@angular/core";
import {v4 as uuidv4} from 'uuid';
import {CreateCollegeCommand, CreateTodoListCommand, ICollegeClient, TodoListsClient} from "../web-api-client";

@Component({
  selector: 'app-college',
  templateUrl: './college.component.html',
  styleUrls: ['./college.component.css']
})
export class CollegeComponent {
  CollegeForm: FormGroup
  Name: string
  submitted = false

  constructor(private formBuilder: FormBuilder, private collegeClient: ICollegeClient,) {
    this.CollegeForm = this.formBuilder.group({
      Name: ['', [Validators.required]],
    })
  }

  submit() {
    console.log("data submitted to server")
    const uuid = uuidv4();
    const headers = {'content-type': 'application/json'}
    const body = {
      'Name': this.CollegeForm.get('Name').value,
      'Uuid': uuid
    }

    this.collegeClient.create(<CreateCollegeCommand>{name: this.Name}).subscribe(
      result => {
      },
      error => {
        let errors = JSON.parse(error.response);
        setTimeout(() => document.getElementById("title").focus(), 250);
      }
    );
  }
}
