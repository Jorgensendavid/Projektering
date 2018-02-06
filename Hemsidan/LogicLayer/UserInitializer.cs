using Hemsidan;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class UserInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        //protected override void Seed(ApplicationDbContext context)
        //{
        //    var store = new UserStore<ApplicationUser>(context);
        //    var usermanager = new ApplicationUserManager(store);

        //    for (int i = 0; i < 5; i++)
        //    {
        //        var user = new ApplicationUser { Email = $"User{i}@user.se" };
        //        usermanager.CreateAsync(user, "User1!").Wait();
        //    }
        //    base.Seed(context);
        //}
    }
}
