using System.Web.Mvc;

namespace MvcModulePj.Areas.Blue
{
    public class BlueAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Blue";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Blue_default",
                "Blue/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}