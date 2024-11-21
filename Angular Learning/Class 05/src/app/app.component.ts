import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

interface Employee {
  name: string;
  age: number;
  id?:number;
}
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'app';
  // isValid:boolean = false;

  isLoggedIn:boolean = true;

  age:number = 10;
  login():void{
    this.isLoggedIn = true;
  }
  logout():void{
    this.isLoggedIn = false;
  }
  namee:string = "Abdullah";

  employes:Employee[] = [
    { name: "John", age: 25 },
    { name: "Jane", age: 30 },
    { name: "David", age: 35 },
    { name: "Emily", age: 40 },
    { name: "Michael", age: 45 },
    { name: "Sarah", age: 50 },
  ]
}
