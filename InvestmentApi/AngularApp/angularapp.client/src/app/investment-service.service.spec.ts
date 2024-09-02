import { TestBed } from '@angular/core/testing';

import { InvestmentServiceService } from './investment-service.service';

describe('InvestmentServiceService', () => {
  let service: InvestmentServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InvestmentServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
