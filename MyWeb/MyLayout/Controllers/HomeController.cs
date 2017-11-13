using System.Collections.Generic;
using System.Web.Mvc;
using MyLayout.Models;


namespace MyLayout.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            //Session.Clear();
            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {

            return View(new RegistrationModel());
        }

        [HttpPost]

        public ActionResult Registration(RegistrationModel model)
        {

            //  ViewBag.Name = name;
            if (this.ModelState.IsValid)
            {
                /* ViewBag.Message = string.Format("Validation Successful: {0} {1} {2}  {3} {4} {5} {6}"
                     , model.Name, model.Email, model.Username, model.Password, model.ConfirmPassword,
                     model.DateOfBirth, model.Gender);*/
                ViewBag.Message = string.Format("Validation Successful");
            }
            List<User> users = new List<User>()
            {
                new User()
                {
                    UserName=model.Username,
                    Name = model.Name,
                    Email = model.Email,
                    Password = model.Password,
                    Gender = model.Gender,
                    DateOfBirth = model.DateOfBirth,
                }};

            Session["users"] = users;
            return View(model);
        }

        [HttpGet]
        public ActionResult Login()
        {

            return View(new LoginModel());
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            List<User> users = (List<User>)Session["users"];
            //List<User> users = Session["users"] as List<User>;

            foreach (User user in users)
            {
                
                if (user.UserName == model.UserName )
                {
                    if ((string)Session["pass"] == model.Password)
                    {
                        Session["users"] = users;
                        //Session["login"] = users;
                        Session["UserName"] = model.UserName;
                        Session["birth"] = user.DateOfBirth;
                        Session["email"] = user.Email;
                        Session["gender"] = user.Gender;
                        Session["pass"] = model.Password;
                        
                        return RedirectToAction("LoggedInProfile", "Private");
                        

                    }
                    else if (user.Password == model.Password)
                    {
                        Session["users"] = users;
                        //Session["login"] = users;
                        Session["UserName"] = model.UserName;
                        Session["birth"] = user.DateOfBirth;
                        Session["email"] = user.Email;
                        Session["gender"] = user.Gender;
                        Session["pass"] = user.Password;

                        return RedirectToAction("LoggedInProfile", "Private");
                    }
                    else
                        ViewBag.Message = string.Format("Wrong password ");
                }
                else
                    ViewBag.Message = string.Format("Wrong input ");

            }

            return View(model);
        }
        
    }

}