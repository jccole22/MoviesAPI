using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviesAPI.Controllers
{
    // Had to comment out while working. Uncomment if it was going to be deployed
    //[Route("api/[controller]")]
    //[ApiController]
    public class ErrorsController : ControllerBase
    {
        //[Route("/error-development")]
        public IActionResult HandleErrorDevelopment([FromServices] IHostEnvironment hostEnvironment)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                return NotFound();
            }

            var exceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerFeature>()!;

            return Problem(detail: exceptionHandlerFeature.Error.StackTrace, title: exceptionHandlerFeature.Error.Message);
        }

        //[Route("/error")]
        public IActionResult HandleError()
        {
            return Problem();
        }

        //[HttpGet("Throw")]
        public IActionResult Throw()
        {
            throw new Exception("Sample Exception");
        }
    }

    
}
