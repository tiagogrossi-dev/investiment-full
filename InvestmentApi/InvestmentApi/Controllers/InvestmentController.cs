using InvestmentApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentController : ControllerBase
    {
        private readonly InvestmentService _investmentService;

        public InvestmentController()
        {
            _investmentService = new InvestmentService();
        }

        [HttpPost]
        public ActionResult<InvestmentResult> CalculateInvestment([FromBody] InvestmentRequest request)
        {
            if (request == null || request.InitialValue <= 0 || request.Months < 2)
            {
                return BadRequest("Os dados do investimento são inválidos.");
            }

            var result = _investmentService.CalculateInvestment(request);

            return Ok(result);
        }
    }
}
