import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Event',
  templateUrl: './Event.component.html',
  styleUrls: ['./Event.component.scss']
})
export class EventComponent implements OnInit {

  events: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEvent();
  }
  getEvent(){
    this.http.get('http://localhost:5000/api/values').subscribe(
      response => {this.events = response},
      error => {console.log(error)}
    )
  }
}
