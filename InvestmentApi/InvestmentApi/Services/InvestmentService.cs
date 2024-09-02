using InvestmentApi.Models;

public class InvestmentService : IInvestmentService
{
    private const decimal CDI = 0.009m;
    private const decimal TB = 1.08m;

    public InvestmentResult CalculateInvestment(InvestmentRequest request)
    {
        InvestmentResult result = new InvestmentResult();

        result = CalculateInvestmentResult(request.InitialValue, request.Months);

        return result;
    }

    private InvestmentResult CalculateInvestmentResult(decimal initialValue, int months)
    {
        decimal grossAmount = initialValue;
        for (int i = 0; i < months; i++)
        {
            grossAmount *= (1 + (CDI * TB));
        }

        decimal netAmount = grossAmount - CalculateTax(grossAmount - initialValue, months);

        return new InvestmentResult
        {
            GrossAmount = Math.Round(grossAmount, 2),
            NetAmount = Math.Round(netAmount, 2)
        };
    }

    private decimal CalculateTax(decimal profit, int months)
    {
        decimal taxRate;

        if (months <= 6)
        {
            taxRate = 0.225m;
        }
        else if (months <= 12)
        {
            taxRate = 0.20m;
        }
        else if (months <= 24)
        {
            taxRate = 0.175m;
        }
        else
        {
            taxRate = 0.15m;
        }

        return profit * taxRate;
    }
}
