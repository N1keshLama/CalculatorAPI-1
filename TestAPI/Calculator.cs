using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[Controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public string Test(){
            return "Test";
        }

        [HttpGet]
        public decimal Add(decimal num1, decimal num2)
        {  
           decimal sum = num1 + num2;
            return sum;
        }
        
        [HttpGet]
        public decimal Subtract(decimal num1, decimal num2)
        {  
           decimal subractResult = num1 - num2;
            return subractResult;
        }
        [HttpGet]
        public decimal Multiply(decimal num1, decimal num2)
        {  
           decimal MulResult = num1 * num2;
            return MulResult;
        }
        [HttpGet]
        public decimal Divide(decimal num1, decimal num2)
        {  
           decimal DivResult = num1 / num2;
            return DivResult;
        }
        [HttpGet]
        public decimal Modulo(decimal num1, decimal num2)
        {  
           decimal ModResult = num1 % num2;
            return ModResult;
        }
    
    }
}