using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("/reply")]
    public class testController : ControllerBase
    {
            [HttpGet]
            public string reply()
          {
            return "Get request working !";
          }

    }
}
