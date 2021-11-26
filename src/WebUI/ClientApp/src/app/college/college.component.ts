import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {Component, OnInit, TemplateRef} from "@angular/core";
import {v4 as uuidv4} from 'uuid';
import {CollegeClient, CreateCollegeCommand, PaginatedListOfCollegeDto, TodosVm,} from "../web-api-client";
import {HttpClient} from "@angular/common/http";
import {CollegeService} from "../services/CollegeService";
import {Observable} from "rxjs";
import {faPlus, IconDefinition} from '@fortawesome/free-solid-svg-icons';
import {faTimes} from "@fortawesome/free-solid-svg-icons";
import {BsModalRef, BsModalService} from "ngx-bootstrap/modal";
import {faEllipsisH} from "@fortawesome/free-solid-svg-icons";
import {faArrowAltCircleLeft} from "@fortawesome/free-solid-svg-icons";

@Component({
  selector: 'app-college',
  templateUrl: './college.component.html',
  styleUrls: ['./college.component.css']
})
export class CollegeComponent implements   OnInit{
  faPlus=faPlus
  cicleLeft=faArrowAltCircleLeft
  totalItems: number;
  modalRef?: BsModalRef;
  times:IconDefinition=faTimes
  faEllipsisH = faEllipsisH;
  CollegeForm: FormGroup
  Name: string
  Submitted: boolean = false
  Status: string
  Colleges: any = []
  newListModalRef: BsModalRef
  newListEditor: any = {};
  constructor(private formBuilder: FormBuilder, private collegeClient: CollegeClient, private httpClient: HttpClient,  private modalService: BsModalService) {
    this.CollegeForm = this.formBuilder.group({
      Name: ['', [Validators.required]],
    })
  }

  addCollege() {
    console.log("data submitted to server")
    const uuid = uuidv4();
    const body = {
      'Name': this.CollegeForm.get('Name').value,
      'Uuid': uuid
    }

    this.collegeClient.create(<CreateCollegeCommand>{name: this.CollegeForm.get('Name').value, uuid: uuid}).subscribe(
      result => {
        this.Submitted = true;
        this.Status = result.toString();
        this.newListModalRef.hide();
        this.newListEditor = {};
        this.fetchColleges();
      },
      error => {
        let errors = JSON.parse(error.response);

        if (errors && errors.Title) {
          this.newListEditor.error = errors.Title[0];
        }
        setTimeout(() => document.getElementById("title").focus(), 250);
      }
    );
  }
  fetchColleges(){
    this.collegeClient.getCollegeWithPagination(1, 1, 100).subscribe(data => {
      this.Colleges = data.items
      this.totalItems=data.totalCount
    })
  }
  ngOnInit() {
    this.fetchColleges()
  }
  addNewCollegeModal(template: TemplateRef<any>): void {
    this.newListModalRef = this.modalService.show(template);
    setTimeout(() => document.getElementById("title").focus(), 250);
  }
  newCollegeCancelled(): void {
    this.newListModalRef.hide();

  }
}


