using BookstoreManagement.Communication.Requests;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Application.UseCases.Books.Register
{
    public class RegisterBookValidator : AbstractValidator<RequestBook>
    {
        public RegisterBookValidator()
        {
            RuleFor(book => book.Title).NotEmpty().WithMessage("The title is required.");
            RuleFor(book => book.Amount).GreaterThan(0).WithMessage("The Amount must be greater than zero.");
            RuleFor(book => book.Price).GreaterThan(0).WithMessage("The Amount must be greater than zero.");
            RuleFor(book => book.Gender).IsInEnum().WithMessage("Gender Type is not valid.");
        }
    }
}
