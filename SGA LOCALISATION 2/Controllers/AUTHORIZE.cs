using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SGA_LOCALISATION_2.MODELS;

namespace SecuDeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorizeController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetSecret()
        {
            return Ok(" info secrète ");
        }



    }
}