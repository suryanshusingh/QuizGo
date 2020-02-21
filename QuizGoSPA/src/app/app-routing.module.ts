import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './_components/login/login.component';
import { QuestionsComponent } from './questions/questions.component';


const routes: Routes = [
  { path: 'login', component: LoginComponent},
    { path: 'quiz', component: QuestionsComponent},
     { path: '', redirectTo: '/login', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
