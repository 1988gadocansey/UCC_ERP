import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BackendlayoutComponent } from './backendlayout.component';

describe('BackendlayoutComponent', () => {
  let component: BackendlayoutComponent;
  let fixture: ComponentFixture<BackendlayoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BackendlayoutComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BackendlayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
