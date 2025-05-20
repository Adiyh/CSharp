using LaptopService.Core.Services.Interface;
using LaptopService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LaptopWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly ILaptopService _laptopService;

        public DeviceController(ILaptopService laptopService)
        {
            try
            {
                _laptopService = laptopService;
            }
            catch (Exception ex )
            {
                StatusCode(500, "An Error has occured:" + ex.Message);
                throw;
            }
        }

        [HttpGet]
        [Route("GetAllLaptopDetails")]
        public IActionResult GetAllLaptopDetails()
        {
            try
            {
                var laptops = _laptopService.GetAllLaptopDetails();
                if (laptops == null || !laptops.Any())
                {
                    return NotFound("No Laptops are there");
                }
                return Ok(laptops);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An Error has occured:"+ex.Message);
            }
        }


        [HttpGet]
        [Route("GetLaptopDetailsById/{id}")]
        public ActionResult<Laptop> GetLaptopDetailsById(int id)
        {
            try
            {
                var laptop = _laptopService.GetLaptopDetailsById(id);
                if (laptop == null)
                    return NotFound();

                return Ok(laptop);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An Error has occured:" + ex.Message);
            }
        }

        [HttpPost]
        [Route("AddNewLaptopDetails")]
        public IActionResult AddNewLaptopDetails(Laptop laptop)
        {
            try
            {
                _laptopService.AddNewLaptopDetails(laptop);
                return Ok("Laptop added successfully");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An Error has occured:" + ex.Message);
            }
            
        }

        [HttpPut]
        [Route("UpdateLaptopDetails")]
        public IActionResult UpdateLaptopDetails(Laptop laptop)
        {

            try
            {
                var existingLaptop = _laptopService.GetLaptopDetailsById(laptop.Id);
                if (existingLaptop == null)
                {
                    return NotFound($"Laptop with ID {laptop.Id} does not exist.");
                }

                
                _laptopService.UpdateLaptopDetails(laptop);
                return Ok("Laptop updated successfully");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An Error has occured:" + ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var existingLaptop = _laptopService.GetLaptopDetailsById(id);
                if (existingLaptop == null)
                {
                    return NotFound($"Laptop with ID {id} does not exist.");
                }

                _laptopService.DeleteLaptopById(id);
                return Ok($"Laptop with ID {id} deleted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An Error has occured:" + ex.Message);
            }
        }

    }
}
    