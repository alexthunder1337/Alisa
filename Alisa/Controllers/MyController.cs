using Microsoft.AspNetCore.Mvc;

namespace Alisa.Controllers
{
    [ApiController]
    [Route(template: "/")]
    public class MyController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
           return "It works!";
        }
    }
}