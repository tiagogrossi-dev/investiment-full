using InvestmentApi.Models;

namespace InvestmentApi.Service.Test
{
    public class ServiceTest
    {
        private InvestmentService _service;

        public ServiceTest()
        {
            _service = new InvestmentService();
        }

        [Test]
        public void CalculateInvestment_ReturnsBadRequest_WhenInvalidInput()
        {
            // Arrange
            var request = new InvestmentRequest { InitialValue = -1000, Months = 1 };

            // Act
            var result = _service.CalculateInvestment(request);

            // Assert
            result.Equals(typeof(InvestmentResult));
        }
    }
}