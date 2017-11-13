﻿using System;
using System.ComponentModel.DataAnnotations;


namespace MyLayout.Models
{
    public class ProfileModel
    {

        public string UserName { get; set; }
        //public string Name { get; set; }
        public string Email { get; set; }
        //public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}