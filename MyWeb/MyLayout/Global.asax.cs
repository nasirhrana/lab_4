using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyLayout
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start()
        {
            List<User> users = new List<User>()
            {
                new User()
                {
                    UserName="bob",
                    Name = "Bob Marsh",
                    Email = "bob@aiub.edu",
                    Password = "123",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1999, 9, 19)
                },
                new User()
                {
                    UserName="anne",
                    Name = "Anne Mishel",
                    Email = "anne@gmail.edu",
                    Password = "123",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1996, 6, 17)
                },
                new User()
                {
                    UserName="kent",
                    Name = "Clark Kent",
                    Email = "kent@aiub.edu",
                    Password = "123",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2000, 3, 27)
                }
            };
            Session["users"] = users;
        }

    }

    public class User
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}