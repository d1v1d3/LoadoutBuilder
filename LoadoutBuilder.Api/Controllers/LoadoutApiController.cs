using LoadoutBuilder.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LoadoutBuilder.Api.Controllers
{
    [Route("api/[controller]")]
    public class LoadoutController : BaseApiController
    {
        private readonly ILoadoutService _service;
        public LoadoutController(ILoadoutService service)
        {
            _service = service;
        }
        [HttpDelete("{loadoutId?}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SoftDeleteLoadoutAsync(int? loadoutId)
        {
            int id = loadoutId ?? -1;
            if (id == -1)
            {
                return BadRequest();
            }
            bool isDeleted = await _service.SoftDeleteLoadoutAsync(id);
            if (!isDeleted)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
