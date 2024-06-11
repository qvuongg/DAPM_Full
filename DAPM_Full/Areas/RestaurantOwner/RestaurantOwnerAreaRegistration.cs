using Owin;
using System.Web.Mvc;

namespace DAPM_Full.Areas.RestaurantOwner
{
    public class RestaurantOwnerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "RestaurantOwner";
            }
        }



        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "RestaurantOwner_default",
                "RestaurantOwner/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "DAPM_Full.Areas.RestaurantOwner.Controllers" }
            );
        }
    }

}
