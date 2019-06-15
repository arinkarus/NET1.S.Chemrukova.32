using System;
using System.Web;

namespace WebApp.Infrastructure
{
    public class ImageHttpModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.PostResolveRequestCache += (sender, args) =>
            {
                var controller = (string)context.Context.Request.RequestContext.RouteData.Values["controller"];
                var id = context.Context.Request.RequestContext.RouteData.Values["id"];
                if ((string.Equals(controller, "Image", StringComparison.OrdinalIgnoreCase) && id != null))
                {
                    context.Context.RemapHandler(new ImageHttpHandler());
                }
            };

        }
    }
}