using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;
using Models.DB;

namespace Controllers;

public class UserController : Controller{

    public IActionResult Login(){
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(User user){
        return new JsonResult(user);
    }

    public IActionResult Register(){
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(User user){
        if(user.Email == null || !user.Email.Contains("@")){
            ModelState.AddModelError("Email", "Email must contain @");
        }

        if(user.Password == null || user.Password.Length <= 3){
            ModelState.AddModelError("Password", "Password must be longer than 3");
        }

        if(user.PasswordRetype == null || !user.PasswordRetype.Equals(user.Password)){
            ModelState.AddModelError("PasswordRetype", "Passwords don't match");
        }

        if(user.Birthdate > DateTime.Today){
            ModelState.AddModelError("Birthdate", "Birthdate must be in the past");
        }

        if(!ModelState.IsValid){
            return View(user);
        }

        using(WebsiteContext con = new WebsiteContext()){
            PasswordHasher<User> hasher = new PasswordHasher<User>();

            user.Password = hasher.HashPassword(user, user.Password);

            con.Users.Add(user);

            await con.SaveToDbAsync(con);
        }

        return RedirectToAction("index", "home");
    }
    
}