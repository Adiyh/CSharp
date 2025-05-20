using LaptopService.Core.Services.Interface;
using LaptopService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaptopManagementSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LaptopsController : ControllerBase
    {
        private readonly ILaptopService _laptopService;

        public LaptopsController(ILaptopService laptopService)
        {
            _laptopService = laptopService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Laptop>>> GetAllLaptops()
        {
            var laptops = await _laptopService.GetAllLaptopsAsync();
            return Ok(laptops);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Laptop>> GetLaptopById(int id)
        {
            var laptop = await _laptopService.GetLaptopByIdAsync(id);
            if (laptop == null)
                return NotFound();
            return Ok(laptop);
        }

        [HttpPost]
        public async Task<IActionResult> AddLaptop([FromBody] Laptop laptop)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _laptopService.AddLaptopAsync(laptop);
            return CreatedAtAction(nameof(GetLaptopById), new { id = laptop.Id }, laptop);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLaptop(int id, [FromBody] Laptop laptop)
        {
            if (id != laptop.Id)
                return BadRequest("Laptop ID mismatch.");

            await _laptopService.UpdateLaptopAsync(laptop);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLaptop(int id)
        {
            await _laptopService.DeleteLaptopAsync(id);
            return NoContent();
        }
    }
}
