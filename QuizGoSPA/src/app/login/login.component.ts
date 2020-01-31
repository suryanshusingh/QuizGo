import { Component, OnInit, Output } from '@angular/core';
import { NgForm } from "@angular/forms"
import { from } from 'rxjs';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {

  constructor(private authService: AuthService) { }
  data1: any;
  ngOnInit() {
  }

  onSubmit(name: string, email: string){
    this.authService.trylogin(name, email).subscribe(
      (data: any) => {
        this.data1 = data;
      }, error => {
        this.showerror(error);
      }
    )
  } 

  showerror(error1: any)
  {
    let error = error1;
  }

}
