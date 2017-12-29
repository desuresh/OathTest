using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT.RentCoder.Model
{
public class CompanyViewModel : BasicUserViewModel
    {
        public int CompanyID { get; set; }
        public int ResourceTypeID { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public int SituationID { get; set; }
        public int IsWorkRemote { get; set; }
        public int AreYouReayToStartWork { get; set; }
        public string Skills { get; set; }
        public string CompanySize { get; set; }
        public string CompanyDescription { get; set; }

    }
}
