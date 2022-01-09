import { Injectable } from '@angular/core';
import { BehaviorSubject, ReplaySubject } from 'rxjs';
import { User } from '../Models/user';

@Injectable()
export class UserSubject {


    private m_userObs = new BehaviorSubject<User>(new User());
    user = this.m_userObs.asObservable();

    constructor() { }
    updateUser(data: any) {
        this.m_userObs.next(data);
    }

    getUser() {
        return this.m_userObs.value;
    }
}

