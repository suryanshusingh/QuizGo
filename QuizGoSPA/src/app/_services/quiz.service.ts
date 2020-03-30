import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Question } from '../_models/question';
import { map } from 'rxjs/operators';

const httpheader = {
  headers: new HttpHeaders( {
    'Authorization': 'Bearer ' + localStorage.getItem('token')
  })
}

@Injectable({
  providedIn: 'root'
})

export class QuizService {
  readonly rootUrl = 'http://localhost:5000/api/';

constructor(private httpClient: HttpClient) { }

getQuestions() : Observable<Question[]>{
  return this.httpClient.get<Question[]>(this.rootUrl + 'quiz/questions', httpheader)
  .pipe(
    map((response: any) => {
      const res = response;
      return res;
    })
  )
}

}
