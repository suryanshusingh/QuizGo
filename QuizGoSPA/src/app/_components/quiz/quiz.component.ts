import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
export class QuizComponent implements OnInit {
  showConfirmationDialog = true;
  showQuestions = false;

  constructor() { }

  ngOnInit() {
  }

  startShowingQuestions(value: boolean) {
    this.showQuestions = value;
  }


}
