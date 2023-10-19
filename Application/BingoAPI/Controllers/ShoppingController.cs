using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MazeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingController : ControllerBase
    {

        [HttpPost("NewCard")]
        [SwaggerOperation("Desc")]
        [SwaggerResponse(StatusCodes.Status200OK, "200", typeof(ActionResult<bool>))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "400", typeof(ActionResult<bool>))]
        public async Task<IActionResult> NewBingoCard()
        {
            return Ok();
        }
    }
}