import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})


export class AuthService {

  readonly rootUrl = 'http://localhost:5000/api/';
constructor(private httpClient: HttpClient) {
 }

 trylogin(name: string, email:string) {
   var body = {
     Name:name,
     Email:email
   }
   return this.httpClient.post(this.rootUrl + 'login', body);
 }

}
