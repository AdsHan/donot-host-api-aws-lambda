using Microsoft.AspNetCore.Mvc;

namespace HostLambda.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        [HttpGet("get-teste-1")]
        public async Task<IActionResult> GetTeste1()
        {
            return Ok("Teste Ok 1");
        }

        [HttpGet("get-teste-2")]
        public async Task<IActionResult> GetTeste2()
        {
            return Ok("Teste Ok 2");
        }
    }
}