using System.Web.Mvc;

namespace MvcModulePj.Areas.Red
{
    public class RedAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Red";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Red_default",
                "Red/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}