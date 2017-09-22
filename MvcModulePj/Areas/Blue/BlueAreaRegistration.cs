using System;
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
                AreaName,
                String.Format("Parent/{0}/{{action}}/{{id}}", AreaName),
                new { controller = AreaName, action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}