import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HoursReporting } from '../Models/hoursReporting';
import { Project } from '../Models/project';
import { ProjectUser } from '../Models/projectUser';
import { User } from '../Models/user';
import { HttpMethod, HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class AppService {
  user: User = new User();
  constructor(private m_httpService: HttpService) {

  }

  getProjectsByUser(userId? :number): Observable<ProjectUser[]> {
    return new Observable(observer => {
      return this.m_httpService.execute<any>("ProjectUser/GetProjectsByUser/"+userId, HttpMethod.Get)
        .subscribe(
          res => {
            observer.next(res);
          });
    });
  }

  getHouresRepoting(): Observable<HoursReporting[]> {
    return new Observable(observer => {
      return this.m_httpService.execute<any>("HoursReporting", HttpMethod.Get)
        .subscribe(
          res => {
            observer.next(res);
          });
    });
  }
  addHouresRepoting(HoursReporting: HoursReporting): Observable<HoursReporting> {
    return new Observable(observer => {
      return this.m_httpService
        .execute<HoursReporting>("HoursReporting", HoursReporting, HttpMethod.Post)
        .subscribe(
          res => {
            observer.next(res);
          })
    });
  }

  login(password: string): Observable<User> {
    return new Observable(observer => {
      return this.m_httpService.execute<any>("User/Login",  '"'+ password + '"', HttpMethod.Post)
        .subscribe(
          res => {
            observer.next(res);
          });
    });
  }
}
