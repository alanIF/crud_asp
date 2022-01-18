using FluentValidation;
using SquadManage.Models;

namespace SquadManage.Validator
{
    public class UserValidator: AbstractValidator<UserViewModel>
    {
        public UserValidator() { 
            RuleFor(user=> user.Email).NotNull().WithMessage("Nao pode ser vazio!") ;
            RuleFor(user => user.Email).EmailAddress().WithMessage("Email incorreto!");

            RuleFor(user => user.Password).NotNull().WithMessage("Nao pode ser vazio!");
            RuleFor(user => user.Username).NotNull().WithMessage("Nao pode ser vazio!") ;

        }
    }
}
