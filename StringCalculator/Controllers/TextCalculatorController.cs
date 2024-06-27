using Microsoft.AspNetCore.Mvc;
using System;

namespace StringCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly TextCalculator _calculator;

        public CalculatorController(TextCalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] string numbers)
        {
            try
            {
                var result = _calculator.Add(numbers);
                return Ok(result);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}