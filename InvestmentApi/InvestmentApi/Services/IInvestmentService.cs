using InvestmentApi.Models;

public interface IInvestmentService
{
    InvestmentResult CalculateInvestment(InvestmentRequest request);
}