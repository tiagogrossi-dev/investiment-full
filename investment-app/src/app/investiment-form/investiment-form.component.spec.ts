import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { InvestimentFormComponent } from './investiment-form.component';
import { InvestmentService } from '../investment-service.service';

describe('InvestmentFormComponent', () => {
  let component: InvestimentFormComponent;
  let fixture: ComponentFixture<InvestimentFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [InvestimentFormComponent],
      imports: [ReactiveFormsModule, HttpClientTestingModule],
      providers: [InvestmentService]
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InvestimentFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create the component', () => {
    expect(component).toBeTruthy();
  });

});
