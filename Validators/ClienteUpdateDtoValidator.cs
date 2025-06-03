namespace CrudMinimalApi.Validators;

using FluentValidation;
using CrudMinimalApi.Models.DTOs;

public class ClienteUpdateDtoValidator : AbstractValidator<ClienteUpdateDto>
{
    public ClienteUpdateDtoValidator()
    {
        
        RuleFor(x => x.Nome)
            .NotEmpty()
            .WithMessage("Nome é obrigatório.")
            .Length(2, 100);

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();
        
        RuleFor(x => x.CPF)
            .NotEmpty()
            .WithMessage("CPF é obrigatório")
            .Length(9)
            .WithMessage("Apenas números.");
    }
    
}