using ExceptionFilterDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ExceptionFilterDemo.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var error = new ExceptionModel
            {
                Status = "500",
                Message = context.Exception.Message
            };

            context.Result = new JsonResult(error) { StatusCode = 500 };
        }
    }
}
