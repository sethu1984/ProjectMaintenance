using System.Web.Mvc;

namespace ProjectMaintenance.Areas.MasterRecord
{
    public class MasterRecordAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MasterRecord";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "MasterRecord_default",
                "MasterRecord/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
