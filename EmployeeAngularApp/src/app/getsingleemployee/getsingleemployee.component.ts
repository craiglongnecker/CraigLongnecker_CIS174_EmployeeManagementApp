import { Component, OnInit, Input } from '@angular/core';
import { Employee } from '../employee';

@Component({
  selector: 'app-getsingleemployee',
  templateUrl: './getsingleemployee.component.html',
  styleUrls: ['./getsingleemployee.component.css']
})
export class GetSingleEmployeeComponent implements OnInit {
  @Input() employee: Employee

  constructor() {}

  ngOnInit() {
  }

}
