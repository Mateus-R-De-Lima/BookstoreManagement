using BookstoreManagement.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Application.UseCases.Books.GetAll
{
    public class GetAllBooksUseCases
    {
        public ResponseAllBooks Execute()
        {
            return new ResponseAllBooks()
            {
                Books = new List<ResponseBook>
                {
                   new ResponseBook
                   {
                       Id = Guid.NewGuid(),
                       Title = "Testes",
                       Price = 10,
                       Gender = "Testes Gender",
                       Amount = 1,
                       
                       
                   }
                }
            };
        }
    }
}
