using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT.RentCoder.Model
{
  public  class FreelancerViewModel : BasicUserViewModel
    {
        public int UserProfileID { get; set; }
        public string FullLegalName { get; set; }
        public string AboutMe { get; set; }
        public string AditionalSkills { get; set; }
        public string ResumePath { get; set; }
        public string LinkedInProfileURL { get; set; }
        public string GitHubUserName { get; set; }
        public string WhatisThisCodeAbout { get; set; }
        public string  ProgrammingExperiance { get; set; }
        public string  CurrentJobTitle { get; set; }
        public string CurrentCompany { get; set; }
        public string CompanyWebsite { get; set; }
        public string CharacterizesYouAsAnEngineer { get; set; }

    }
}
