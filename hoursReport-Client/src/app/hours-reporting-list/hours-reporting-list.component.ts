import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ColDef, Module } from 'ag-grid-community';
import { AppService } from '../services/app.service';
import 'ag-grid-enterprise';
import 'ag-grid-community/dist/styles/ag-grid.css';
import 'ag-grid-community/dist/styles/ag-theme-alpine.css';
import { Router } from '@angular/router';

@Component({
  selector: 'app-hours-reporting-list',
  templateUrl: './hours-reporting-list.component.html',
  styleUrls: ['./hours-reporting-list.component.scss']
})
export class HoursReportingListComponent implements OnInit {

  constructor(private m_appService: AppService, private m_datePipe: DatePipe, private m_router: Router) {
    const comp = this;
    comp.columnDefs = [
      { field: 'userName' },
      {
        field: 'date',
        sortable: false,
        // valueFormatter: ((param) => { return this.m_datePipe.transform(param.data.date, 'DD/MM/YYYY') ? +''})
      },
      {
        field: 'begingingTime',
        sortable: false
      },
      {
        field: 'endTime',
        sortable: false
      },
      { field: 'projectName' }
    ];
    this.defaultColDef = {
      sortable: true,
      resizable: true,
      minWidth: 100,
      flex: 1,
    };
  }
  columnDefs: ColDef[] = [];
  defaultColDef: any;
  rowData: any;
  gridColumnApi: any;
  gridApi: any;

  ngOnInit(): void {

  }

  exportExcel() {
    this.gridApi.exportDataAsExcel();
  }
  onGridReady(params: any) {
    this.gridApi = params.api;
    this.gridColumnApi = params.columnApi;
    this.m_appService.getHouresRepoting().subscribe(res => {
      this.rowData = res;

    });
  }
  navigateHome() {
    this.m_router.navigate(['home']);
  }


}
