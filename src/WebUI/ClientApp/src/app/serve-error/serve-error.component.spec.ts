import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServeErrorComponent } from './serve-error.component';

describe('ServeErrorComponent', () => {
  let component: ServeErrorComponent;
  let fixture: ComponentFixture<ServeErrorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ServeErrorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ServeErrorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
