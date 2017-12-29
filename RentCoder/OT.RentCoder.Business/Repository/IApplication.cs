using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT.RentCoder.Business.Repository
{
    public interface IApplication
    {
        List<OT_Country> GetCountry();
        List<OT_Characterizes> GetCharacterizes();
        List<OT_Decision> GetDecisions();
        List<OT_ResourceType> GetResourceType();
        List<OT_Situation> GetSituation();
        List<OT_Skills> GetSkills();
        List<OT_TimeZone> GetTtimeZones();
        List<O> GetUserType();


    }
}
