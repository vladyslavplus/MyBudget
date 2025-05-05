﻿namespace MyBudget.BLL.DTOs.User;

public class UserResponseDto
{
    public int Id { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool IsBlocked { get; set; }
}