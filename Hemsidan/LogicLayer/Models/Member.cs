using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public virtual ICollection<Chore> Chores {get; set;}
    }
}
