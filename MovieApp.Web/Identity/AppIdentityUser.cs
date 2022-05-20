using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Identity
{
    public class AppIdentityUser : IdentityUser 
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
