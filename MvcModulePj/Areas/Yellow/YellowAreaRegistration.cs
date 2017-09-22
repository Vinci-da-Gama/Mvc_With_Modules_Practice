using System.Web.Mvc;

namespace MvcModulePj.Areas.Yellow
{
    public class YellowAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Yellow";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Yellow_default",
                "Yellow/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}