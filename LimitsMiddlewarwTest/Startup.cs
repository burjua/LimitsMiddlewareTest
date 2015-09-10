using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LimitsMiddlewarwTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MaxUrlLength(2048);
            
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });
        }
    }
}