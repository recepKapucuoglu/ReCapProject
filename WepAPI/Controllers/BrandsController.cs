using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        
            IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getallbrand")]
        public IActionResult GetAllBrand()
        {
           var result= _brandService.GetAllBrand();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        //post 
        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var result =_brandService.AddToBrand(brand);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
