using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public double Power(double num1, double num2)
        {
            var calc = new Math();
            return calc.Power(num1, num2);
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
            var calc = new Math();
            return calc.Remainder(num1, num2);
        }

        
        [HttpGet("min")]
        public int Min(int num1, int num2)
        {
            var calc = new Math();
            return calc.Min(num1, num2);
        }

        
        [HttpGet("max")]
        public int Max(int num1, int num2)
        {
            var calc = new Math();
            return calc.Max(num1, num2);
        }

        
        [HttpGet("sin")]
        public double Sin(double angle)
        {
            var calc = new Math();
            return calc.Sin(angle);
        }
}
