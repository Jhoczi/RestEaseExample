using Microsoft.AspNetCore.Mvc;
using RestEaseExample.Models;

namespace RestEaseExample.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly List<User> _users;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
        _users = new List<User>()
        {
            new User()
            {
                Id = 1,
                Username = "j.smith",
                FullName = "James Smith",
                CreatedAt = DateTime.Today
            },
            new User()
            {
                Id = 2,
                Username = "jxcik",
                FullName = "Jasmine Rose",
                CreatedAt = DateTime.Today.AddDays(-2)
            }
        };
    }

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        var result = _users.FirstOrDefault(user => user.Id == id);

        if (result == null)
        {
            return BadRequest("User not found.");
        }
        return Ok(result);
    }
}