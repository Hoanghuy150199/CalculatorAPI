using Microsoft.AspNetCore.Mvc;
using CalculatorAPI.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/<CalculatorController>/5
        [HttpGet("add/{a}/{b}")]
        public string add(float a, float b)
        {
            var cal = new Calculator(a, b);
            cal.add();
            return cal.result.ToString();
        }

        [HttpGet("sub/{a}/{b}")]
        public string sub(float a, float b)
        {
            var cal = new Calculator(a, b);
            cal.sub();
            return cal.result.ToString();
        }

        [HttpGet("mul/{a}/{b}")]
        public string mul(float a, float b)
        {
            var cal = new Calculator(a, b);
            cal.mul();
            return cal.result.ToString();
        }
    }
}
