using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MYAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MYAPIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello Gowdre");
        }

        [HttpPost]
        public IActionResult Vertex()
        {
            return NoContent();
        }

        [HttpPut]
        public IActionResult Adarsh()
        {
            return Ok("Good Night");
        }

        [HttpDelete]
        public IActionResult akash()
        {

            return NoContent();
        }

    }
}

    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private static readonly List<CalculatorOperation> Operations = new();

        // Create a new operation
        [HttpPost("create")]
        public IActionResult CreateOperation([FromBody] CalculatorOperation operation)
        {
            if (operation == null || string.IsNullOrEmpty(operation.OperationType))
            {
                return BadRequest("Invalid operation data.");
            }

            operation.Id = Operations.Count + 1;
            operation.Result = PerformOperation(operation);
            Operations.Add(operation);

            return CreatedAtAction(nameof(GetOperation), new { id = operation.Id }, operation);
        }

        // Read an operation by ID
        [HttpGet("read/{id}")]
        public IActionResult GetOperation(int id)
        {
            var operation = Operations.Find(op => op.Id == id);
            if (operation == null)
            {
                return NotFound("Operation not found.");
            }

            return Ok(operation);
        }

        // Update an existing operation
        [HttpPut("update/{id}")]
        public IActionResult UpdateOperation(int id, [FromBody] CalculatorOperation updatedOperation)
        {
            var operation = Operations.Find(op => op.Id == id);
            if (operation == null)
            {
                return NotFound("Operation not found.");
            }

            operation.Num1 = updatedOperation.Num1;
            operation.Num2 = updatedOperation.Num2;
            operation.OperationType = updatedOperation.OperationType;
            operation.Result = PerformOperation(operation);

            return Ok(operation);
        }

        // Delete an operation by ID
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteOperation(int id)
        {
            var operation = Operations.Find(op => op.Id == id);
            if (operation == null)
            {
                return NotFound("Operation not found.");
            }

            Operations.Remove(operation);
            return NoContent();
        }

        // Helper method to perform the calculation
        private double PerformOperation(CalculatorOperation operation)
        {
            return operation.OperationType.ToLower() switch
            {
                "add" => operation.Num1 + operation.Num2,
                "subtract" => operation.Num1 - operation.Num2,
                "multiply" => operation.Num1 * operation.Num2,
                "divide" => operation.Num2 != 0 ? operation.Num1 / operation.Num2 : double.NaN,
                _ => throw new InvalidOperationException("Invalid operation type.")
            };
        }
    }

    // Model for calculator operations
    public class CalculatorOperation
    {
        public int Id { get; set; }
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string OperationType { get; set; } 
        public double Result { get; set; }
    }
