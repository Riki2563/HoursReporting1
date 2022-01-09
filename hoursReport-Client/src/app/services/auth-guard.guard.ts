import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { CONSTANTS } from '../constant';
import { UserSubject } from './user.subject';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardGuard implements CanActivate {
  constructor(private m_userSubject: UserSubject, private m_router: Router) {

  }
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    let user = this.m_userSubject.getUser();
    if ((route.url.toString().includes("List") && user.role == CONSTANTS.WORKER_ROLE) || !user.userId) {
      this.m_router.navigate(['login']);
      return false;
    }
    else {
      return true;
    }
  }
}
