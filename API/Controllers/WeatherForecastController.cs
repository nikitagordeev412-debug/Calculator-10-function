using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // будет: /api/math
    public class MathController : ControllerBase
    {
        [HttpGet("sum")]
        public double Sum(int num1, int num2)
        {
            var calc = new Math();
            return calc.Sum(num1, num2);
        }

        
        [HttpGet("subtraction")]
        public double Subtraction(int num1, int num2)
        {
            var calc = new Math();
            return calc.Subtraction(num1, num2);
        }

        
        [HttpGet("mult")]
        public double Mult(int num1, int num2)
        {
            var calc = new Math();
            return calc.Mult(num1, num2);
        }

        
        [HttpGet("division")]
        public double Division(int num1, int num2)
        {
            var calc = new Math();
            return calc.Division(num1, num2);
        }

        
        [HttpGet("power")]
        public double Power(double @base, double exponent)
        {
            var calc = new Math();
            return calc.Power(@base, exponent);
        }

        
        [HttpGet("sqrt")]
        public double Sqrt(double value)
        {
            var calc = new Math();
            return calc.Sqrt(value);
        }

        
        [HttpGet("remainder")]
        public int Remainder(int num1, int num2)
        {
            var calc = new MathOperations();
            return calc.Remainder(num1, num2);
        }

        
        [HttpGet("min")]
        public int Min(int num1, int num2)
        {
            var calc = new MathOperations();
            return calc.Min(num1, num2);
        }

        
        [HttpGet("max")]
        public int Max(int num1, int num2)
        {
            var calc = new MathOperations();
            return calc.Max(num1, num2);
        }

        
        [HttpGet("sin")]
        public double Sin(double angle)
        {
            var calc = new MathOperations();
            return calc.Sin(angle);
        }
}
