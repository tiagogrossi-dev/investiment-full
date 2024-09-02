import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InvestmentService {

  private apiUrl = 'https://localhost:7155/api/Investment';

  constructor(private http: HttpClient) { }

  calculateInvestment(data: { initialValue: number, months: number }): Observable<any> {
    console.log('Enviando para API:', {
      initialValue: data.initialValue,
      months: data.months
    });
    
    return this.http.post<any>(this.apiUrl, data);
  }
}
