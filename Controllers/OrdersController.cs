using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/Controller")]
    public class OrdersController : ControllerBase
    {
        //[HttpGet("AllOrders")]
        //public async Task<IActionResult> GetOrders()
        //{ 

            
        //}


    }
}
