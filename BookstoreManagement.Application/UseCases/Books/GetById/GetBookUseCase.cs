using BookstoreManagement.Communication.Responses;

namespace BookstoreManagement.Application.UseCases.Books.GetById
{
    public class GetBookUseCase
    {
        public ResponseBook Execute(Guid id)
        {
            return new ResponseBook()
            {
                Id = Guid.NewGuid(),
                Title = "Testes",
                Price = 10,
                Gender = "Testes Gender",
                Amount = 1,
            };
        }
    }
}
