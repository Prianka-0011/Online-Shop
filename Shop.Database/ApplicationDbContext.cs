using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Database
{
   public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext()
        {

        }
    }
}
