﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using WebMatrix.WebData;
using System.Web.Security;

namespace MvcMusicStore3
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebSecurity.InitializeDatabaseConnection("DefaultConnection",
                "UserName", "UserId", "UserName", true);

            //WebSecurity.CreateUserAndAccount("admin", "admin");
            //Roles.CreateRole("Administrator");
            //Roles.AddUserToRole("admin", "Administrator");

            System.Data.Entity.Database.SetInitializer(
                new MvcMusicStore3.Models.SampleData());

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}