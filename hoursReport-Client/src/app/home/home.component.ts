import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CONSTANTS } from '../constant';
import { HoursReporting } from '../Models/hoursReporting';
import { User } from '../Models/user';
import { UserSubject } from '../services/user.subject';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor(private m_userSubject: UserSubject, private m_router: Router) { }
  user: User = new User();
  managerRole=CONSTANTS.MANAGER_ROLE;
  ngOnInit(): void {
    this.user = this.m_userSubject.getUser()
    console.log(this.user);

  }
  navigateForm() {
    this.m_router.navigate(['hoursReportingForm']);
  }
  navigateList() {
    this.m_router.navigate(['hoursReportingList']);
  }
}
