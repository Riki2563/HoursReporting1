import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { CONSTANTS } from '../constant';
import { User } from '../Models/user';
import { AppService } from '../services/app.service';
import { UserSubject } from '../services/user.subject';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(private m_appService: AppService, private m_router: Router, private m_useSubject: UserSubject) { }
  hide: boolean = true;
  password = new FormControl('', [Validators.required]);
  email = new FormControl('', [Validators.required]);
  isExist: boolean = false;
  ngOnInit(): void {
  }

  login() {
    this.m_appService.login(this.password.value).subscribe(res => {
      if (res && res.email == this.email.value) {
        this.m_useSubject.updateUser(res);
        this.navigate(res)
      }
      else {
        this.isExist = true;
      }
    });
  }

  navigate(user: User) {
    if (user.role == CONSTANTS.MANAGER_ROLE) {
      this.m_router.navigate(['hoursReportingList']);
    }
    else {
      this.m_router.navigate(['home']);
    }
  }
}
