import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public questions: Question[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Question[]>(baseUrl + 'api/SampleData/Questions').subscribe(result => {
      this.questions = result;
    }, error => console.error(error));
  }
}

interface Question {
  QuestionId:number
  Title: string;
  Content: string;
}
