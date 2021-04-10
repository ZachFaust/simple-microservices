using System.Threading;
using System.Collections.Generic;
using gateway.Models;

namespace gateway.Hubs.Clients {
    public interface IClockStreamClient{
        IAsyncEnumerable<long> StreamClock(CancellationToken cancellationToken);
        IAsyncEnumerable<TimerResponse> StreamTimer(CancellationToken cancellationToken, TimerRequest req);
    }

}