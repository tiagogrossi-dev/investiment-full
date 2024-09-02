import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InvestimentFormComponent } from './investiment-form.component';

describe('InvestimentFormComponent', () => {
  let component: InvestimentFormComponent;
  let fixture: ComponentFixture<InvestimentFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InvestimentFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InvestimentFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
