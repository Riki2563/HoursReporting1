import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { AlertDialogComponent } from '../alert-dialog/alert-dialog.component';
import { HoursReporting } from '../Models/hoursReporting';
import { Project } from '../Models/project';
import { User } from '../Models/user';
import { AppService } from '../services/app.service';
import { UserSubject } from '../services/user.subject';

@Component({
  selector: 'app-hours-reporting-form',
  templateUrl: './hours-reporting-form.component.html',
  styleUrls: ['./hours-reporting-form.component.scss']
})
export class HoursReportingFormComponent implements OnInit {

  begingingTime = new FormControl('', [Validators.required]);
  endTime = new FormControl('', [Validators.required]);
  projectId = new FormControl('', [Validators.required]);
  user: User = new User;
  hoursRoporting: HoursReporting = new HoursReporting();
  date: any;
  projects: Project[] = []
  isValid: boolean = true;
  constructor(private m_appService: AppService, private m_userSubject: UserSubject, private m_datePipe: DatePipe, private m_router: Router, public m_dialog: MatDialog,) { }

  ngOnInit(): void {
    this.user = this.m_userSubject.getUser();
    this.hoursRoporting.userId = this.user.userId;
    this.hoursRoporting.user = this.user;
    this.hoursRoporting.date = new Date();
    this.date = this.m_datePipe.transform(this.hoursRoporting.date, 'yyyy-MM-dd');
    this.m_appService.getProjectsByUser(this.user.userId).subscribe(res => {
      this.projects = res;
    })
  }
  saveForm() {
    if (this.hoursRoporting.begingingTime && this.hoursRoporting.endTime && this.hoursRoporting.projectId) {
      this.isValid = true
      delete this.hoursRoporting.user;
      this.m_appService.addHouresRepoting(this.hoursRoporting).subscribe(res => {
        const dialogRef = this.m_dialog.open(AlertDialogComponent, {
          width: "650px",
          height: "300px",
          disableClose: true,
          data: { title: 'succses', message: 'Hours reporting successfully added' }
        });
        this.navigateHome();
      })
    }
    else {
      this.isValid = false
    }
  }
  navigateHome() {
    this.m_router.navigate(['home']);
  }
}
