using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Library.Models
{
    public class UserDbContext : IdentityDbContext<User>
    {
        public UserDbContext() : base("IdentityDb") { }

        public static UserDbContext Create()
        {
            return new UserDbContext();
        }
    }
}