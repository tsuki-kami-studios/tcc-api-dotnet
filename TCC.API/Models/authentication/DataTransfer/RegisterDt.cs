﻿namespace TCC.API.models.authentication.DataTransfer;

public class RegisterDt
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public ulong RoleId { get; set; }

    public static implicit operator User(RegisterDt register) =>
        new()
        {
            Username = register.Username,
            Password = register.Password,
            Email = register.Email,
            RoleId = register.RoleId
        };
}