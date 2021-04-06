using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Grpc.Net.Client;
using Protoclock;
using System.Threading;

namespace gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // grpc example
            //AppContext.SetSwitch(
            //    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            //var channel = GrpcChannel.ForAddress("http://localhost:8080");
            //var client = new Protoclock.clockService.clockServiceClient(channel);

            //var cancellationToken = new CancellationToken();
            //using var call = client.currentTime(new currentTimeRequest{});
            //while (await call.ResponseStream.MoveNext(cancellationToken)) {
            //    Console.WriteLine("Time: " + call.ResponseStream.Current.Time.ToDateTime().ToString());
            //}
            // actual service start
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
