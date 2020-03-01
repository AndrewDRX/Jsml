using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

using Jsml.Enums;
using Jsml.Loadables;

namespace Jsml.Server
{
    class JsmlWebServer
    {
        public static IWebHost Create(LoadableElement root) =>
            WebHost
                .CreateDefaultBuilder()
                .Configure(configureApp: app =>
                    app.Run(handler: async context => {
                        context.Response.ContentType = "text/html";
                        await context.Response.WriteAsync(text: root.Dom.ToString());
                    })
                )
                .Build();
    }
}
