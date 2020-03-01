import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-startconfirmation',
  templateUrl: './startconfirmation.component.html',
  styleUrls: ['./startconfirmation.component.css']
})
export class StartConfirmationComponent implements OnInit {
  @Output() showQuestions = new EventEmitter();
  display='none';
  @Input() showConfirmation: boolean;
  
  constructor(private router: Router) { }

  ngOnInit() {
    this.openModal();
  }
 
  openModal(){
  this.display='block';
}
  startQuiz(){
    this.showConfirmation = false;
    let showQuestionNow: boolean = true;
    this.showQuestions.emit(showQuestionNow);
  }
}
