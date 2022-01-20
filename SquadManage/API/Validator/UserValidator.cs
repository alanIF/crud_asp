using Common;
using FluentValidation;

namespace API.Validator
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Username).NotNull().WithMessage("username nao pode ser vazio!");

            RuleFor(user => user.Email).NotNull().WithMessage("email Nao pode ser vazio!");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Email incorreto!");

            RuleFor(user => user.Password).NotNull().WithMessage("senha Nao pode ser vazio!");
            RuleFor(user => user.Password).Equal(o=> o.confirmPassword).WithMessage("A senha deve ser igual ao confirmar senha!");

        }
    }
}
