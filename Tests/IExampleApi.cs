using System.Threading.Tasks;
using Tests.Models;

namespace Tests;
using RestEase;

[Header("User-Agent", "RestEase")]
public interface IExampleApi
{
    [Get("User")]
    Task<UserDto> GetUserAsync([Query("id")] int userId);
}
