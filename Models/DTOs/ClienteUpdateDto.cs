﻿namespace CrudMinimalApi.Models.DTOs;

public class ClienteUpdateDto
{
    public string Nome { get; set; } =  string.Empty;
    public string Email { get; set; } =   string.Empty;
    public string CPF { get; set; } =  string.Empty;
}