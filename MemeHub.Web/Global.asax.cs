using System.IO.MemoryMappedFiles;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Models.ViewModels.Users;

namespace MemeHub.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureMapping();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMapping()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<Meme, UserMemeViewModel>();
                expression.CreateMap<ApplicationUser, UserProfileViewModel>();
            });
        }
    }
}
