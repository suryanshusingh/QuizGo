import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { LoginComponent } from './_components/login/login.component';
import { FormsModule, ReactiveFormsModule }  from '@angular/forms';
import { AuthService } from './_services/auth.service';
import { HttpClientModule } from '@angular/common/http';
import { QuestionsComponent } from './questions/questions.component';
import { AppRoutingModule } from './app-routing.module';
import { QuizService } from './_services/quiz.service';

@NgModule({
   declarations: [
      AppComponent,
      LoginComponent,
      QuestionsComponent
   ],
   imports: [
      BrowserModule,
      FormsModule,
      ReactiveFormsModule,
      HttpClientModule,
      AppRoutingModule
   ],
   providers: [
      AuthService,
      QuizService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
