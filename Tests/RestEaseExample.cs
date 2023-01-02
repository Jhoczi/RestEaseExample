using System;
using System.Threading.Tasks;
using FluentAssertions;
using RestEase;
using Tests.Models;
using Xunit;

namespace Tests;

public class RestEaseExample
{
    [Fact]
    public async Task ExampleTest()
    {
        IExampleApi api = RestClient.For<IExampleApi>("https://localhost:7086");
        UserDto userDto = await api.GetUserAsync(1);

        userDto.Should().NotBeNull();
    }
}