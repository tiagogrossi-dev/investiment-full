import { TestBed } from '@angular/core/testing';
import { InvestmentService } from './investment-service.service';
import { HttpClientTestingModule } from '@angular/common/http/testing';

describe('InvestmentService', () => {
  let service: InvestmentService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],  // Adicione o HttpClientTestingModule aqui
      providers: [InvestmentService]
    });
    service = TestBed.inject(InvestmentService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
