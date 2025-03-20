using BookstoreManagement.Communication.Requests;
using BookstoreManagement.Communication.Responses;
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

            return new ResponseBook()
            {
                Amount = request.Amount,
                Gender = request.Gender,
                Price = request.Price,
                Title = request.Title,
                Id = Guid.NewGuid()
            };



        }
    }
}
