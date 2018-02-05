using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
   public class CustomUserStore : UserStore<ApplicationUser>
    {
        public CustomUserStore(ApplicationDbContext context) : base(context)
        {

        }
    }
}
