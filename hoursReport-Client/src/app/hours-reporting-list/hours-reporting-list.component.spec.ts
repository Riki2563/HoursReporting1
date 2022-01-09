import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HoursReportingListComponent } from './hours-reporting-list.component';

describe('HoursReportingListComponent', () => {
  let component: HoursReportingListComponent;
  let fixture: ComponentFixture<HoursReportingListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HoursReportingListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HoursReportingListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
