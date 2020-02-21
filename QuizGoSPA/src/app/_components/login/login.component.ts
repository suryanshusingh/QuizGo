import { Component, OnInit, Output } from '@angular/core';
import { NgForm, FormGroup, FormBuilder } from "@angular/forms"
import { AuthService } from '../../_services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  loginForm: FormGroup;

  constructor(private authService: AuthService, private route: Router,
    private fb: FormBuilder) { }
  ngOnInit() {
    this.createLoginForm();
  }

  createLoginForm() {
    this.loginForm = this.fb.group({
      email: [''],
      password: ['']}
          );
  }


  login() {
    if (this.loginForm.valid) {
      this.authService.login(this.loginForm.value.email, 
        this.loginForm.value.password).subscribe(error => {
            console.log("Netork Error");
        }, () => {
          //this.route.navigate(['/questions']);
          console.log('success');
        });
    }
  }

}
