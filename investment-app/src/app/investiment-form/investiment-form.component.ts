import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InvestmentService } from '../investment-service.service';

@Component({
  selector: 'app-investiment-form',
  templateUrl: './investiment-form.component.html',
  styleUrls: ['./investiment-form.component.css']
})
export class InvestimentFormComponent {
  investmentForm!: FormGroup;
  result: { grossAmount: number, netAmount: number } | null = null;

  constructor(private fb: FormBuilder, private investmentService: InvestmentService) {
    this.investmentForm = this.fb.group({
      initialValue: [null, [Validators.required, Validators.min(1)]],
      months: [null, [Validators.required, Validators.min(2)]], // Controle 'months'
    });
  }

calculateInvestment() {
  if (this.investmentForm.valid) {
    const { initialValue, months } = this.investmentForm.value;

    // Enviar os dados para a API e obter o resultado calculado
    this.investmentService.calculateInvestment({ initialValue, months })
      .subscribe(
        response => {
          // Atualizar o resultado com os valores recebidos da API
          this.result = {
            grossAmount: response.grossAmount,
            netAmount: response.netAmount
          };
          console.log('Dados recebidos da API:', this.result);
        },
        error => {
          console.error('Erro ao enviar dados para a API', error);
        }
      );
    }
  }
}
