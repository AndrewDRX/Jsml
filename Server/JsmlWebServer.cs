using System;
using System.Linq;
using System.IO;
using System.Threading;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.FileProviders;

using System.Net.WebSockets;

using Jsml.Loadables;

namespace Jsml.Server
{
    class JsmlWebServer
    {
        public static IWebHost Create(LoadableElement root) =>
            new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .Configure(configureApp: app => {
                    app.UseWebSockets();
                    app.Use(async (context, next) => {
                        if (context.Request.Path == "/ws")
                        {
                            if (context.WebSockets.IsWebSocketRequest)
                            {
                                WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
                                var buffer = new byte[1024 * 4];
                                WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                                while (!result.CloseStatus.HasValue)
                                {
                                    await webSocket.SendAsync(new ArraySegment<byte>(buffer, 0, result.Count), result.MessageType,
                                    result.EndOfMessage, CancellationToken.None);
                                    result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                                }
                                await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
                            }
                            else
                            {
                                context.Response.StatusCode = 400;
                            }
                        }
                        else
                        {
                            await next();
                        }
                    });
                    app.UseStaticFiles(new StaticFileOptions {
                        FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Example")),
                        RequestPath = ""
                    });
                    app.UseFileServer();
                    app.Run(handler: async context => {
                        context.Response.ContentType = "text/html";
                        await context.Response.WriteAsync(
                            text: root.Dom.ToString()
                        );
                    });
                })
                .Build();
    }
}
