import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MaintenaceComponent } from './maintenace.component';

describe('MaintenaceComponent', () => {
  let component: MaintenaceComponent;
  let fixture: ComponentFixture<MaintenaceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MaintenaceComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MaintenaceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
