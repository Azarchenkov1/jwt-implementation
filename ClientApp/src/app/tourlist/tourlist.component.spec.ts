import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TourlistComponent } from './tourlist.component';

describe('TourlistComponent', () => {
  let component: TourlistComponent;
  let fixture: ComponentFixture<TourlistComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TourlistComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TourlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
