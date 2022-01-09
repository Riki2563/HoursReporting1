import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HoursReportingFormComponent } from './hours-reporting-form.component';

describe('HoursReportingFormComponent', () => {
  let component: HoursReportingFormComponent;
  let fixture: ComponentFixture<HoursReportingFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HoursReportingFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HoursReportingFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
