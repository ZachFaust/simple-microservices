using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading;
using Grpc.Net.Client;
using Protoclock;
using System.Threading;
using System.Runtime.CompilerServices;
using gateway.Hubs.Clients;

namespace gateway.Hubs
{
    public class ClockStreamHub : Hub<IClockStreamClient>
    {
        public async IAsyncEnumerable<long> StreamClock(
            [EnumeratorCancellation] CancellationToken cancellationToken
            //[EnumeratorCancelation]
        )

            {
                AppContext.SetSwitch(
                    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
                var channel = GrpcChannel.ForAddress("http://localhost:8080");
                var client = new Protoclock.clockService.clockServiceClient(channel);

                using var call = client.currentTime(new currentTimeRequest{});
                while (await call.ResponseStream.MoveNext(cancellationToken)) {
                    Console.WriteLine("Time: " + call.ResponseStream.Current.Time.ToDateTime().ToString());
                    yield return call.ResponseStream.Current.Time.Seconds;
                }
            }

    }
}