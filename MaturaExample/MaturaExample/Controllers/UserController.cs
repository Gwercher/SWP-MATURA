using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            if(userDb == null){
                ModelState.AddModelError("Email", "Incorrect Login Information");
                return View(user);
            }

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

            await con.SaveToDbAsync();
        }

        return RedirectToAction("index", "home");
    }
    
    public async Task<IActionResult> ShowUsers(){
        using(WebsiteContext con = new WebsiteContext()){
            List<User> users = await con.Users.ToListAsync();
            return View(users);
        }
    }

    public async Task<IActionResult> ChangeUser(string email){
        using(WebsiteContext con = new WebsiteContext()){
            User? user = await con.Users.FindAsync(email);

            return View(user);
        }
    }

    [HttpPost]
    public async Task<IActionResult> ChangeUserPost(User user){
        if(user.Birthdate > DateTime.Today){
            ModelState.AddModelError("Birthdate", "Birthdate must be in the past");
        }

        if(!ModelState.IsValid){
            return View("ChangeUser", user);
        }

        using(WebsiteContext con = new WebsiteContext()){
            User? userFromDb = await con.Users.FindAsync(user.Email);

            if(userFromDb == null){
                return View("ChangeUser", user);
            }

            userFromDb.Birthdate = user.Birthdate;
            userFromDb.Role = user.Role;
            await con.SaveToDbAsync();

            return RedirectToAction("ShowUsers", "User");
        }

    }

    public IActionResult Deleteuser(string email){
        return new JsonResult(email);
    }

}