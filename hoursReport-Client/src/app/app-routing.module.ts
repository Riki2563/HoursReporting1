import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { HoursReportingFormComponent } from './hours-reporting-form/hours-reporting-form.component';
import { HoursReportingListComponent } from './hours-reporting-list/hours-reporting-list.component';
import { LoginComponent } from './login/login.component';
import { AuthGuardGuard } from './services/auth-guard.guard';

const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'home',  canActivate: [AuthGuardGuard], component: HomeComponent },
  { path: 'hoursReportingForm', canActivate: [AuthGuardGuard], component: HoursReportingFormComponent },
  { path: 'hoursReportingList', canActivate: [AuthGuardGuard], component: HoursReportingListComponent },
]


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {


}
