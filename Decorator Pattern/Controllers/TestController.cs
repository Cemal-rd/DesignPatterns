using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Decorator_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Test")]
        public IActionResult Get()
        {
            using var context = new TestDbContext();

            context.Users.Add(new UserEntity()
            {
                Id = 1,
                FullName = "Salih Cantekin"
            });


            return Ok();
        }
    }
}
