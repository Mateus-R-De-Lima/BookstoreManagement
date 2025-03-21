using BookstoreManagement.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Application.UseCases.Books.Delete
{
    public class DeleteBookUseCase
    {
        public bool Execute(Guid id)
        {
            var list = new List<ResponseBook>()
            {
                new ResponseBook()
                {
                    Id = Guid.Parse("fe4fa59a-913a-4f18-be73-139ffd0fdb1f"),
                    Title = "Livro 1",
                    Amount = 10,
                    Gender = "Action",
                    Price = 10,
                },
                  new ResponseBook()
                {
                    Id = Guid.Parse("d2dc1c07-3d1e-4d45-9399-846891df63fa"),
                    Title = "Livro 2",
                    Amount = 1,
                    Gender = "fiction",
                    Price = 100,
                },


            };

            var response = list.FirstOrDefault(book => book.Id == id);

            if (response is null)
            {
                return false;
            }

            list.Remove(response);

            return true;
        }
    }
}
