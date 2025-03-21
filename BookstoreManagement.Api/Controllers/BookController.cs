using BookstoreManagement.Application.UseCases.Books.Delete;
using BookstoreManagement.Application.UseCases.Books.GetAll;
using BookstoreManagement.Application.UseCases.Books.GetById;
using BookstoreManagement.Application.UseCases.Books.Register;
using BookstoreManagement.Application.UseCases.Books.Update;
using BookstoreManagement.Communication.Requests;
using BookstoreManagement.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Principal;

namespace BookstoreManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : BaseController
    {

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(List<ResponseBook>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErros), StatusCodes.Status400BadRequest)]
        public override IActionResult GetAll()
        {
            var useCase = new GetAllBooksUseCases();
            var response = useCase.Execute();
            if (response.Books.Any())
            {
                return Ok(response);
            }

            return NoContent();


        }

        [HttpGet("{id}")]

        public override IActionResult Get(Guid id)
        {
            var useCase = new GetBookUseCase();

            var response = useCase.Execute(id);

            if (response is null) return NotFound("Book not found!");

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<ResponseBook>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErros), StatusCodes.Status400BadRequest)]
        public IActionResult Post(RequestBook entity)
        {
            var useCase = new RegisterBookUseCase();

            var response = useCase.Execute(entity);

            return Created("", response);


        }

        [HttpPut]
        public IActionResult Put([FromHeader] Guid id, RequestBook entity)
        {
            var useCase = new UpdateBookUseCase();

            var response = useCase.Execute(id, entity);

            if (response is null) return NotFound("Book not found!");


            return NoContent();

        }

        [HttpDelete("{id}")]
        public override IActionResult Delete(Guid id)
        {
            var useCase = new DeleteBookUseCase();
            var response = useCase.Execute(id);
            if (!response) return NotFound("Book not found!");
            return NoContent();
        }

    }
}
