using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT.RentCoder.Model
{
    public class BasicUserViewModel
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SkypeName { get; set; }
        public string InitiatID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserTypeID { get; set; }
    }
}
