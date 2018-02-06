using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Models
{
    public class Family
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> Members { get; set; }
   
        public virtual ICollection<Chore> chore { get; set; }
    }
}
