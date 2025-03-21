using BookstoreManagement.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Application.UseCases.Books.GetAll
{
    public class GetAllBooksUseCases
    {/// <summary>
     /// Use case to get All Books
     /// </summary>
     /// <returns></returns>
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

                   },
                   new ResponseBook
                     {
                        Id = Guid.NewGuid(),
                        Title = "Livro 1",
                        Amount = 10,
                        Gender = "Action",
                        Price = 10,
                      },
                   new ResponseBook
                    {
                        Id = Guid.NewGuid(),
                        Title = "Livro 2",
                        Amount = 1,
                        Gender = "fiction",
                        Price = 100,
                    }
                }
            };
        }
    }
}
