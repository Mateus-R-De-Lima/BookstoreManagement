using BookstoreManagement.Communication.Responses;

namespace BookstoreManagement.Application.UseCases.Books.GetById
{
    public class GetBookUseCase
    {
        public ResponseBook Execute(Guid id)
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

            var book = list.FirstOrDefault(book => book.Id == id);

            if(book is null)
            {
                return null;
            }

            return book;
        }
    }
}
