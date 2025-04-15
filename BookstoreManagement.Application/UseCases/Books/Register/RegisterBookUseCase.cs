using BookstoreManagement.Communication.Requests;
using BookstoreManagement.Communication.Responses;
using BookstoreManagement.Execption.ExceptionsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Application.UseCases.Books.Register
{
    public class RegisterBookUseCase
    {/// <summary>
     /// Use case for creating a new book
     /// </summary>
     /// <param name="request"></param>
     /// <returns></returns>
        public ResponseBook Execute(RequestBook request)
        {
            Validate(request);

            return new ResponseBook()
            {
                Amount = request.Amount,
                Gender = request.Gender,
                Price = request.Price,
                Title = request.Title,
                Id = Guid.NewGuid()
            };
        }

        private void Validate(RequestBook request)
        {
            var validator = new RegisterBookValidator();
            var result = validator.Validate(request);
            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
                throw new ErrorOnValidationsException(errorMessages);

                
            }

        }
    }
}
