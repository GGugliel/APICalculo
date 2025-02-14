using APICalculo.Interfaces;
using APICalculo.Model;
using Microsoft.AspNetCore.Mvc;

namespace APICalculo.Api
{
    /// <summary>
    /// Base controller from service
    /// </summary>
    public abstract class BaseController : ControllerBase
    {
        /// <summary>
        /// Process the response
        /// </summary>
        /// <param name="response">response from request</param>
        /// <returns></returns>
        protected IActionResult ProcessResponse(ResponseErrors response)
        {
            switch (response.StatusCode)
            {
                case StatusCodes.Status200OK:
                    return Ok(response);

                case StatusCodes.Status400BadRequest:
                case StatusCodes.Status403Forbidden:
                case StatusCodes.Status404NotFound:
                    return new BadRequestObjectResult(response);

                default:
                    return new ObjectResult(response) { StatusCode = StatusCodes.Status502BadGateway };
            }
        }
    }
}
