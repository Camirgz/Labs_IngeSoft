using Microsoft.AspNetCore.Mvc;

namespace backend_lab_C36624.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hola Mundo";
        }
    }
}
