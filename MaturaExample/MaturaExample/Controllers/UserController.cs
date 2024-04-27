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
        
        if(user.Email == null || !user.Email.Contains("@")){
            ModelState.AddModelError("Email", "Email must contain @");
        }

        if(user.Password == null || user.Password.Length <= 3){
            ModelState.AddModelError("Password", "Password must be longer than 3");
        }

        if(!ModelState.IsValid){
            return View(user);
        }

        using(WebsiteContext con = new WebsiteContext()){
            PasswordHasher<User> hasher = new PasswordHasher<User>();

            User? userDb = await con.Users.FindAsync(user.Email);

            PasswordVerificationResult hashResult = hasher.VerifyHashedPassword(user, userDb.Password, user.Password);
            
            if(hashResult == PasswordVerificationResult.Failed){
                ModelState.AddModelError("Email", "Incorrect Login Information");
                return View(user);
            }

            HttpContext.Session.SetObject<User>(user, "LOGIN_USER");

            return RedirectToAction("index", "home");
        }
    }

    public IActionResult Logout(){
        HttpContext.Session.Remove("LOGIN_USER");
        return RedirectToAction("index", "home");
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