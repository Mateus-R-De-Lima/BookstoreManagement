using BookstoreManagement.Communication.Requests;
using BookstoreManagement.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : BaseController
    {

        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseBook>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public override IActionResult GetAll()
        {
            var list = new List<ResponseBook>()
            {
                new ResponseBook()
                {
                    Id = Guid.NewGuid(),
                    Title = "Livro 1",
                    Amount = 10,
                    Gender = "Action",
                    Price = 10,
                },
                  new ResponseBook()
                {
                    Id = Guid.NewGuid(),
                    Title = "Livro 2",
                    Amount = 1,
                    Gender = "fiction",
                    Price = 100,
                },


            };

            return Ok(list);


        }

        [HttpGet("{id}")]
        public override IActionResult Get(Guid id)
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

            if (response is null) return NotFound("Book not found!");

            return Ok(response);
        }

        [HttpPost]
        public override IActionResult Post(RequestBook entity)
        {
            var newBook = new ResponseBook()
            {
                Id = Guid.NewGuid(),
                Amount = entity.Amount,
                Gender = entity.Gender,
                Price = entity.Price,
                Title = entity.Title,
            };

            return NoContent();


        }

        [HttpPut]
        public override IActionResult Put([FromHeader] Guid id, RequestBook entity)
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


            if (response is null) return NotFound("Book not found!");


            return NoContent();

        }

        [HttpDelete("{id}")]
        public override IActionResult Delete(Guid id)
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
            if (response is null) return NotFound("Book not found!");

            list.Remove(response);

            return NoContent();
        }

    }
}
