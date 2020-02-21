import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';
import {map} from 'rxjs/operators'

@Injectable({
  providedIn: 'root'
})


export class AuthService {
  jwtHelper = new JwtHelperService();
  decodedToken: any;
  currentUser: any;

  readonly rootUrl = 'http://localhost:5000/api/login/';
  constructor(private http: HttpClient) {
 }
 
 login(email: string, password:string) {
  let body = { email: email, password: password};
  return this.http.post(this.rootUrl + 'login', body).pipe(
    map((response: any) =>  {
      const user = response;
      if (user){
         this.setLocalStorage(user);
      }
    })
  );   
}

setLocalStorage(user:any){
 localStorage.setItem("token", user.token);
 localStorage.setItem('user', JSON.stringify(user.user));
 this.decodedToken = this.jwtHelper.decodeToken(user.token);
 this.currentUser = user.user;
}


}
