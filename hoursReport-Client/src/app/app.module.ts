import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HoursReportingFormComponent } from './hours-reporting-form/hours-reporting-form.component';
import { HoursReportingListComponent } from './hours-reporting-list/hours-reporting-list.component';
import { HomeComponent } from './home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatFormFieldModule, MatLabel } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from "@angular/material/button";
import { MatCardModule } from '@angular/material/card';
import { MatSelectModule } from '@angular/material/select';
import { NgxMaterialTimepickerModule } from 'ngx-material-timepicker';
import { UserSubject } from './services/user.subject';
import { DatePipe } from '@angular/common';
import { AgGridModule } from 'ag-grid-angular';
import { ExcelExportModule } from 'ag-grid-enterprise/dist/lib/main';
import { AlertDialogComponent } from './alert-dialog/alert-dialog.component';
import { MatDialogModule } from '@angular/material/dialog';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HoursReportingFormComponent,
    HoursReportingListComponent,
    HomeComponent,
    AlertDialogComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    MatFormFieldModule,
    MatIconModule,
    FormsModule,
    ReactiveFormsModule,
    MatInputModule,
    MatButtonModule,
    MatCardModule,
    MatSelectModule,
    NgxMaterialTimepickerModule,
    MatDialogModule,
    AgGridModule.withComponents([]),
  ],

  providers: [UserSubject, DatePipe, AlertDialogComponent],
  entryComponents: [AlertDialogComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
