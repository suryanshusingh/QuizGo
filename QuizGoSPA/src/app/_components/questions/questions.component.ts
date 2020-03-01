import { Component, OnInit } from '@angular/core';
import { QuizService } from '../../_services/quiz.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css']
})
export class QuestionsComponent implements OnInit {
  display='none';
  showQuestions = false;

  constructor(private quizService: QuizService, private router: Router) { }

  ngOnInit() {
    //this.quizService.getQuestions();
  }


}
