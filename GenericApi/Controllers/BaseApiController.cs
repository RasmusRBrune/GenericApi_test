using GenericApi.Interface;
using GenericApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController<T> : ControllerBase where T : class
    {
        IBaseService<T> baseService;

        public BaseApiController()
        {
            
        }

        [HttpGet("getall")]
        public async Task<ActionResult<List<T>>> Getall()
        {
            return Ok(await baseService.Getall());
        }


    }
}
