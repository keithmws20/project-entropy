using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace project_entropy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AboutController : ControllerBase
    {

        private Objects.AboutObject aboutObj;

        [HttpGet]
        public IActionResult GetAbout() {
            JsonConvert.SerializeObject(aboutObj);

            return Ok(aboutObj);
        }
        
        
    }
}
