using Microsoft.AspNetCore.Mvc;
using StringIds.Domain.Services;

namespace StringIds.Api.Controllers
{
    public class UserController: ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
    }
}
