using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Library.Models
{
    public class User : IdentityUser
    {
        public string ImagePath { get; set; }
        public User()
        {
        }
    }
}