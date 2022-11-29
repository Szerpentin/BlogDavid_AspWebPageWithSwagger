using Microsoft.AspNetCore.Mvc;

namespace BlogDavid_AspWebPageWithSwagger.Controllers
{
    [Route("api/home")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("getMessage/{message}")]
        public ActionResult<string> Get(string message)
        {
            return $"Your message from get was {message}";
        }


        [HttpPost]
        [Route("postMessage")]
        public ActionResult<string> Post([FromBody] string message)
        {
            return $"Your message from post was {message}";
        }
    }
}
