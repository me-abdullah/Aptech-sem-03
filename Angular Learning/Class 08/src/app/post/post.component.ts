import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-post',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css'] 
})
export class PostComponent implements OnInit {
  deptObj: any = {
    "departmentId": 0,
    "departmentName": "",
    "departmentLogo": ""
  };
  deptList:any[] = [];
  http = inject(HttpClient);
  ngOnInit(): void {
    this.getDepartment();
  }
  onSave(): void { 
    debugger;
    this.http.post(
      "https://projectapi.gerasim.in/api/Complaint/AddNewDepartment",
      this.deptObj
    ).subscribe((response:any) => {
      debugger;
     if (response.result) {
      alert("Department Created Successfully");
     } else {
      alert(response.message);
     }
    });
  }

  getDepartment():void{
    debugger;
    this.http.get('https://projectapi.gerasim.in/api/Complaint/GetParentDepartment')
    .subscribe((response:any) => {
      debugger;
      this.deptList = response.data;
    });
  }
}
