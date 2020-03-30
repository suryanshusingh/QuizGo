import { Component, OnInit } from '@angular/core';
import { QuizService } from '../../_services/quiz.service';
import { Router } from '@angular/router';
import { Question, MCQ1Question, MCQ2Question, SubjectiveQuestion } from 'src/app/_models/question';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css']
})
export class QuestionsComponent implements OnInit {
  display = 'none';
  showQuestions = false;
  questions: any[];

  constructor(private quizService: QuizService, private router: Router) { }

  ngOnInit() {
    this.quizService.getQuestions().subscribe((value: Question[]) => this.showQuestionComponent(value),
      error => {
        console.log('error');
      }, () => {
        console.log('complete');
      });
  }

  showQuestionComponent(value: Question[]) {
    this.questions = value;
    this.questions.forEach(element => {
       var a = element as MCQ1Question;
       if (element['questionType'] == 'Subjective'){
         console.log('subjective');
       }
       else if (element['questionType'] == 'MCQ1'){
        console.log('mcq1');
      }
      if (element['questionType'] == 'MCQ2'){
        console.log('mcq2');
      }
    });
    console.log(this.questions);
  }

}
