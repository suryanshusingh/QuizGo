import { Component, OnInit } from '@angular/core';
import { QuizService } from '../_services/quiz.service';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css']
})
export class QuestionsComponent implements OnInit {

  constructor(private quizService: QuizService) { }

  ngOnInit() {
    this.quizService.getQuestions();
  }

}
