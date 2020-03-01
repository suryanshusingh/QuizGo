import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './_components/login/login.component';
import { QuestionsComponent } from './_components/questions/questions.component';
import { StartConfirmationComponent } from './_components/startconfirmation/startconfirmation.component';
import { QuizComponent } from './_components/quiz/quiz.component';


const routes: Routes = [
  { path: 'login', component: LoginComponent},
    { path: 'questions', component: QuestionsComponent},
    { path: 'startconfirmation', component: StartConfirmationComponent},
    { path: 'quiz', component: QuizComponent},
     { path: '', redirectTo: '/login', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
