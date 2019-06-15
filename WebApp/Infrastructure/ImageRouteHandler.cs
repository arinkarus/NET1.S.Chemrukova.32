using System.Web;
using System.Web.Routing;

namespace WebApp.Infrastructure
{
    public class ImageRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new ImageHttpHandler();
        }
    }
}