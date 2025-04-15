using BookstoreManagement.Communication.Responses;
using BookstoreManagement.Execption.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookstoreManagement.Api.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception is BookstoreManagementExeption)
            {
                HandleProjectExeception(context);
            }
            else
            {
               ThrowUnkowError(context);
            }
        }

        private void HandleProjectExeception(ExceptionContext context)
        {
            if (context.Exception is ErrorOnValidationsException)
            {
                var ex = (ErrorOnValidationsException)context.Exception;
                var erroMessage = new ResponseErros(ex.Errors);
                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(erroMessage);

            }
            else
            { //TODO: Temporario
                var erroMessage = new ResponseErros(context.Exception.Message);
                context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Result = new BadRequestObjectResult(erroMessage);
            }
        }

        private void ThrowUnkowError(ExceptionContext context)
        {
            var erroMessage = new ResponseErros("Unknown error");

            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(erroMessage);


        }
    }
}
