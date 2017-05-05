using System.Configuration;
using System.Data.Entity.Migrations;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using MemeHub.Models.BindingModels.Comments;
using MemeHub.Models.BindingModels.Memes;
using MemeHub.Models.BindingModels.Users;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Comments;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Models.ViewModels.Users;

namespace MemeHub.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var migrator = new DbMigrator(new DbMigrationsConfiguration());
            migrator.Update();
            ConfigureMapping();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AreaRegistration.RegisterAllAreas();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMapping()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<CommentDisplayViewModel, Comment>();
                expression.CreateMap<Comment, CommentDisplayViewModel>();
                expression.CreateMap<Meme, MemeUserViewModel>();
                expression.CreateMap<ApplicationUser, UserProfileViewModel>();
                expression.CreateMap<Meme, MemeDisplayViewModel>();
                expression.CreateMap<ApplicationUser, UserEditViewModel>();
                expression.CreateMap<UserEditBindingModel, ApplicationUser>();
                expression.CreateMap<MemeCreateBindingModel, Meme>();
                expression.CreateMap<Meme, MemeEditViewModel>();
                expression.CreateMap<MemeEditBindingModel, MemeEditViewModel>();
                expression.CreateMap<MemeEditBindingModel, Meme>();
                expression.CreateMap<Meme, MemeDeleteViewModel>();
                expression.CreateMap<Meme, MemeDetailsViewModel>();
                expression.CreateMap<CommentCreateBindingModel, CommentCreateViewModel>();
                expression.CreateMap<CommentCreateViewModel, Comment>();
                expression.CreateMap<CommentDisplayViewModel, Comment>();
                expression.CreateMap<CommentCreateBindingModel, Comment>();
                expression.CreateMap<MemeDetailsViewModel, MemeDetailsBindingModel>();
            });
        }
    }
}
