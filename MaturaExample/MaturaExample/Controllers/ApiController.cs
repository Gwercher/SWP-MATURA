using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DB;

namespace MaturaExample.Controllers;

[Route("api/")]
[ApiController]
public class ApiController : ControllerBase {

    [HttpGet]
    [Route("apiTest")]
    public IActionResult GetTestString(){
        return new JsonResult("Hello, World!");
    }

    [HttpGet]
    [Route("getAllRoles")]
    public IActionResult GetAllRoles(){
        return new JsonResult(Enum.GetNames(typeof(Role)));
    }

    [HttpDelete]
    [Route("deleteUser")]
    public IActionResult DeleteUser(string email){
        using(WebsiteContext con = new WebsiteContext()){
            User? userToDelete = con.Users.Find(email);
            con.Users.Remove(userToDelete);
            con.SaveChanges();
            return new JsonResult("");
        }    
    }

    [HttpPost]
    [Route("getUserByRole")]
    public IActionResult GetUserByRole(Role role){
        using(WebsiteContext con = new WebsiteContext()){
            List<User> users = con.Users.Where(u => u.Role == role).ToList<User>();
            return new JsonResult(users);
        }
    }

    [HttpPost]
    [Route("getAllUsers")]
    public IActionResult GetAllUsers(){
        using(WebsiteContext con = new WebsiteContext()){
            List<User> users = con.Users.ToList<User>();
            return new JsonResult(users);
        }
    }

}