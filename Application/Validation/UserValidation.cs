using Domain;
using FluentValidation;

namespace Application.Message.Validation;

public class UserValidation:AbstractValidator<User>
{
    public UserValidation()
    {
        RuleFor(r => r.Email).EmailAddress().WithMessage("Lütfen Mail Adresi giriniz ");
    }
}