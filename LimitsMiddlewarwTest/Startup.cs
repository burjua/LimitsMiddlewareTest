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
            app.Use().MaxUrlLength(2048); // Doesn't work, what shall I do? Missing usings? Which ones? 
            
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });
        }
    }
}