using System.Web.Mvc;

namespace ProjectMaintenance.Areas.Softwares
{
    public class SoftwaresAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Softwares";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Softwares_default",
                "Softwares/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
