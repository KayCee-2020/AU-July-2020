import { Component,EventEmitter } from '@angular/core';
import {CheckService} from './check.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(private checkService: CheckService) {}
  title = 'A-form';
  dis = 'true';
  notifications= [
    {id:1,title : 'This is the first Title'},
    {id:2,title : 'This is the second Title'},
    {id:3,title : 'This is the third Title'}
  ]

}