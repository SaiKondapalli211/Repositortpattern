using Microsoft.AspNetCore.Mvc;
using Repositortpattern1.Singleton;

namespace Repositortpattern1.Controllers
{
    [ApiController]
    [Route("api/insurance")]
    public class InsuranceController : ControllerBase
    {
        private readonly IPremiumCalculatorService _premiumCalculatorService;

        public InsuranceController(IPremiumCalculatorService premiumCalculatorService)
        {
            _premiumCalculatorService = premiumCalculatorService;
        }

        [HttpGet("calculate-premium")]
        public IActionResult CalculatePremium(int age, string planType, bool hasPreExistingCondition)
        {
            var premium = _premiumCalculatorService.CalculatePremium(age, planType, hasPreExistingCondition);
            return Ok(new { Age = age, PlanType = planType, PremiumAmount = premium });
        }
    }
    }
