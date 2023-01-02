using System;

namespace Tests.Models;

public class UserDto
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string FullName { get; set; }
    public DateTime CreatedAt { get; set; }
}