using System.IO;
using System.Web;

namespace WebApp.Infrastructure
{
    public class ImageHttpHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            //For task 2
            //var imageName = context.Request.QueryString["id"];
            var imageName = context.Request.RequestContext.RouteData.Values["id"];
            string appPath = HttpRuntime.AppDomainAppPath;
            string imageFilePath = $@"{appPath}\Images\{imageName}.jpg";
            if (!File.Exists(imageFilePath))
            {
                context.Response.Write("No such file");
                return;
            }

            context.Response.ContentType = "image/jpg";
            byte[] image = File.ReadAllBytes(imageFilePath);
            context.Response.BinaryWrite(image);
        }
    }
}