using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.Entity.Concrete
{
    public class User : BaseClass
    {
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastLogin { get; set; }
        public string Departman { get; set; }
        public string Role { get; set; }

    }
}