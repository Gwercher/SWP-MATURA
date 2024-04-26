using Microsoft.AspNetCore.Mvc;

namespace MaturaExample.Controllers;

[Route("api/")]
[ApiController]
public class ApiController : ControllerBase {

    [HttpGet]
    [Route("apiTest")]
    public IActionResult GetTestString(){
        return new JsonResult("Hello, World!");
    }

}