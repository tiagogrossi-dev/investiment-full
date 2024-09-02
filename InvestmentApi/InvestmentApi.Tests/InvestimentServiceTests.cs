using InvestmentApi.Models;
using Moq;
using Xunit;

namespace InvestmentApi.Tests
{
    public class InvestmentServiceTest
    {
        private InvestmentService _service;

        public InvestmentServiceTest()
        {
            _service = new InvestmentService();
        }

        [Fact]
        public void CalculateInvestment_ReturnsBadRequest_WhenInvalidInput()
        {
            //_mockService.Setup(x => x.CalculateInvestment(new InvestmentRequest { InitialValue = -1000, Months = 1 }));

            // Arrange
            var request = new InvestmentRequest { InitialValue = -1000, Months = 1 };

            // Act
            _service.CalculateInvestment(request);

            // Assert
            //result.Result.Should().BeOfType<BadRequestObjectResult>(); // Acessa o .Result para verificar o tipo
        }

        //[Fact]
        //public void CalculateInvestment_ReturnsOkResult_WhenValidInput()
        //{
        //    _mockService.Setup(x => x.CalculateInvestment(new InvestmentRequest()));

        //    // Arrange
        //    var request = new InvestmentRequest { InitialValue = 1000, Months = 12 };
        //    var expectedResult = new InvestmentResult { GrossAmount = 1200, NetAmount = 1000 };

        //    _mockService.Setup(x => x.CalculateInvestment(It.IsAny<InvestmentRequest>()))
        //                .Returns(expectedResult);

        //    // Act
        //    var result = _controller.CalculateInvestment(request);

        //    // Assert
        //    result.Result.Should().BeOfType<OkObjectResult>(); // Verifica se o resultado é do tipo OkObjectResult

        //    var okResult = result.Result as OkObjectResult; // Converte para OkObjectResult
        //    okResult.Value.Should().BeOfType<InvestmentResult>(); // Verifica se o valor é do tipo InvestmentResult

        //    var actualResult = okResult.Value as InvestmentResult;
        //    actualResult.Should().BeEquivalentTo(expectedResult); // Compara se os objetos são equivalentes
        //}
    }
}
