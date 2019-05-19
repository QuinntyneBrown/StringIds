using Microsoft.AspNetCore.Mvc;
using StringIds.Core.Models;
using StringIds.Users.Domain.Models;
using StringIds.Users.Domain.Services;
using System.Threading.Tasks;

namespace StringIds.Users.Api.Controllers
{
    [Route("api/users")]
    public class UserController: ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result != null)
                return Ok(result);

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody]User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.InsertAsync(user);
            return Created($"/api/users/{result.UserId}", result);
        }

        [HttpPost("batch")]
        public async Task<IActionResult> InsertBatch([FromBody]Batch<User> users)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.InsertBatchAsync(users.Data);
            return Ok(result);
        }
    }
}
