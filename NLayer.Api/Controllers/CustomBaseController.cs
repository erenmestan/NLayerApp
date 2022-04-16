using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.Api.Controllers
{
    
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CareateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode==204)
            {
                return new ObjectResult(null)
                {
                    StatusCode =response.StatusCode
                };
            }
            return new ObjectResult(response)
            {
                StatusCode=response.StatusCode
            };
        }
    }
}
