import { Injectable } from '@angular/core';
import {HttpClient, HttpErrorResponse} from "@angular/common/http";
import {BehaviorSubject, Observable, Subscription, throwError} from "rxjs";
import {catchError} from "rxjs/operators";

@Injectable({
  providedIn: 'root'
})
export class CollegeService {

  constructor(private  httpClient: HttpClient) { }

  fetchData(): Observable<any> {
    return this.httpClient.get("/api/College?").pipe(
      catchError(this.handleError)
    )
  }
  handleError(error: HttpErrorResponse) {
    if (error.status === 0) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong.
      console.error(
        `Backend returned code ${error.status}, body was: `, error.error);
    }
    // Return an observable with a user-facing error message.
    return throwError(
      'Something bad happened; please try again later.');
  }
  private sub = new BehaviorSubject("v");
  subj$ = this.sub.asObservable();

  send(value: any) {
    this.sub.next(value);
    console.log(value);
  }

  findById(Id: string): Observable<any> {

    return this.httpClient.get(`api/Product/${Id}`).pipe(
      catchError(this.handleError)
    )
  }
  getProductName(product: string):Subscription{
    return this.findById(product).subscribe(
      (response) => {                           //next() callback
        console.log('response received')

      },
      (error) => {                              //error() callback
        console.error('Request failed with error')

      },
      () => {                                   //complete() callback
        console.error('Request completed')      //This is actually not needed

      })

  }
}
