import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {Component, OnDestroy, OnInit, TemplateRef} from "@angular/core";
import {v4 as uuidv4} from 'uuid';
import {CollegeClient, CollegeDto, CollegeVm, CreateCollegeCommand, UpdateCollegeCommand,} from "../web-api-client";
import {HttpClient} from "@angular/common/http";
import {Subject} from "rxjs";
import {faArrowAltCircleLeft, faEllipsisH, faPlus, faTimes, IconDefinition} from '@fortawesome/free-solid-svg-icons';
import {BsModalRef, BsModalService} from "ngx-bootstrap/modal";

@Component({
  selector: 'app-college',
  templateUrl: './college.component.html',
  styleUrls: ['./college.component.css']
})
export class CollegeComponent implements OnInit, OnDestroy {
  private unsubscribe$ = new Subject();

  faPlus = faPlus
  cicleLeft = faArrowAltCircleLeft
  totalItems: number;
  modalRef?: BsModalRef;
  times: IconDefinition = faTimes
  faEllipsisH = faEllipsisH;
  CollegeForm: FormGroup
  EditCollegeForm: FormGroup
  CollegeName: string
  Submitted: boolean = false
  Status: string
  Colleges: any = []
  collegeEditModalRef: BsModalRef;
  newListModalRef: BsModalRef
  newListEditor: any = {};
  collegeDetailsEditor: any = {};
  collegeUpdate: any = {};

  selectedCollege: CollegeDto;
  name: string;
  id: number;

  CollegeVm: CollegeVm;

  constructor(private formBuilder: FormBuilder, private collegeClient: CollegeClient, private httpClient: HttpClient, private modalService: BsModalService) {
    this.CollegeForm = this.formBuilder.group({
      CollegeName: ['', [Validators.required]],
    })
    this.EditCollegeForm = this.formBuilder.group({
      name: ['', [Validators.required]],
      id: ['', [Validators.required]],
    })

  }

  addCollege() {
    console.log("data submitted to server")
    const uuid = uuidv4();
    const body = {
      'Name': this.CollegeForm.get('CollegeName').value,
      'Uuid': uuid
    }

    this.collegeClient.create(<CreateCollegeCommand>{
      name: this.CollegeForm.get('CollegeName').value,
      uuid: uuid
    }).subscribe(
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

  fetchColleges() {
    this.collegeClient.get().subscribe(
      result => {
        this.CollegeVm = result;
        if (this.CollegeVm.lists.length) {
          this.selectedCollege = this.CollegeVm.lists[0];
        }
      },
      error => console.error(error)
    );
  }

  ngOnInit() {
    this.fetchColleges()

  }

  addNewCollegeModal(template: TemplateRef<any>): void {
    this.newListModalRef = this.modalService.show(template);
    setTimeout(() => document.getElementById("CollegeName").focus(), 250);
  }

  newCollegeCancelled(): void {
    this.newListModalRef.hide();
  }

  showCollegeDetailsModal(template: TemplateRef<any>, college: CollegeDto) {
    this.selectedCollege = college;
    this.collegeDetailsEditor = {
      ...this.selectedCollege
    };
    console.log("selected" + this.collegeDetailsEditor.name);
    this.EditCollegeForm.setValue({
        "name": this.collegeDetailsEditor.name,
        "id": this.collegeDetailsEditor.id
      }
    );


    this.collegeEditModalRef = this.modalService.show(template);
  }

  showCollegeCancelled(): void {
    this.collegeEditModalRef.hide();

  }

  updateCollege() {
    //this.collegeDetailsEditor=JSON.stringify(this.EditCollegeForm.getRawValue());
    this.collegeUpdate = {
      name: this.EditCollegeForm.get("name").value,
      id: this.EditCollegeForm.get("id").value
    }
    console.log(JSON.stringify(this.collegeUpdate))
    const id = this.EditCollegeForm.get("id").value;

    this.collegeClient.update(id, UpdateCollegeCommand.fromJS(this.collegeUpdate))
      .subscribe(
        () => {

          // this.selectedCollege.name = this.collegeDetailsEditor.name,
          this.fetchColleges();
          this.collegeEditModalRef.hide();
          this.collegeDetailsEditor = {};
        },
        error => console.error(error)
      );
  }

  ngOnDestroy() {
    this.unsubscribe$.next(true);
    this.unsubscribe$.complete();
  }

}


