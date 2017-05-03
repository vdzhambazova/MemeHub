using System.Web.Mvc;

namespace MemeHub.Web.Areas.Memes
{
    public class MemesAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Memes";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            context.MapRoute(
                "Memes_default",
                "Memes/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}