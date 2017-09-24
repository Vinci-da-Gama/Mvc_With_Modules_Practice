using System;
using System.Configuration;
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

        //public override void RegisterArea(AreaRegistrationContext context) 
        //{
        //    context.MapRoute(
        //        "Red_default",
        //        "Red/{controller}/{action}/{id}",
        //        new { action = "Index", id = UrlParameter.Optional }
        //    );
        //}
        public override void RegisterArea(AreaRegistrationContext context)
        {
            // Determine if it is enabled or not
            Application.ModulesEnabled.Add(AreaName, Convert.ToBoolean(ConfigurationManager.AppSettings[AreaName]));

            context.MapRoute(
                  AreaName,
                  String.Format("Parent/{0}/{{action}}/{{id}}", AreaName),
                  new { controller = AreaName, action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}