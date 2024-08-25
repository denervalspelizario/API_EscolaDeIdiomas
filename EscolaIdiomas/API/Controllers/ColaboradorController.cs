using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {
        [HttpPost]
        [Route("adicionarColaborador/")]
        public async Task<ActionResult> AdicaoColaborador()
        {
            return Ok();
        }

    }
}
