using Business.Abstract;
using Core.Untilities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]

        public IActionResult GetAll() 
        {
            var result= _carService.getAll();
            if (result.Success) 
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarsByBrandId(int id)
        {
           var result =  _carService.GetCarsByBrandId(id);
            if (result.Success) 
            {
                return Ok(result.Data);
            }
            else return BadRequest(result.Data);

        }
        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetCarsByColorId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else return BadRequest(result.Data);

        }


        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else return BadRequest(result.Data);

        }

        [HttpGet("findgetdailyprice")]
        public IActionResult FindGetDailyPrice(int id)
        {
            var result = _carService.FindGetDailyPrice(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else return BadRequest(result.Data);

        }


        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else return BadRequest(result.Message);

        }


        [HttpPut("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else return BadRequest(result.Message);

        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.DeleteCar(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else return BadRequest(result.Message);

        }

    }
}
