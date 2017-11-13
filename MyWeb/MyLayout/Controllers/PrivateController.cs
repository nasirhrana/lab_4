using System.Collections.Generic;
using System.Web.Mvc;
using MyLayout.Models;

namespace MyLayout.Controllers
{
    public class PrivateController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            //Session.Clear();
           // Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ChangePass()
        {
            return View(new PasswordModel());
        }

        public ActionResult ChangePass(PasswordModel model)
        {
            if ((string)Session["pass"]==model.Password)
            {   
                Session["pass"] = model.NewPassword;
                ViewBag.Message = string.Format("change password ");    
            }
            else
                ViewBag.Message = string.Format("Wrong password ");
            return View(model);
        }
        [HttpGet]
        public ActionResult EditProfile()
        {
            return View(new ProfileModel());
        }
        [HttpPost]
        public ActionResult EditProfile(ProfileModel model)
        {


            
                    Session["UserName"] = model.UserName;
                    Session["birth"] = model.DateOfBirth;
                    Session["email"] = model.Email;
                    Session["gender"] = model.Gender;

            List<User> users = new List<User>()
            {
                new User()
                {
                    UserName= model.UserName,

                    Email = model.Email,

                    Gender = model.Gender,
                    DateOfBirth = model.DateOfBirth,
                    Password=(string)Session["pass"]
                }};

            Session["users"] = users;



            return View(model);
        }

        public ActionResult ProfilePicture()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ProfileInfo()
        {

            return View(new User());
        }

        [HttpPost]
        public ActionResult ProfileInfo(User model)
        {
            
           

            return View(model);
        }
        [HttpGet]
        public ActionResult LoggedInProfile()
        {
            return View();
        }
        
    }
}