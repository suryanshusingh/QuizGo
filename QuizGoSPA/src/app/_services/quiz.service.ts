import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class QuizService {
  readonly rootUrl = 'http://localhost:5000/api/';

constructor(private httpClient: HttpClient) { }

getQuestions(){
  this.httpClient.get(this.rootUrl + 'quiz');
}

}
