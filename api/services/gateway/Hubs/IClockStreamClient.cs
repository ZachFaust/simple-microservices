using System.Threading;
using System.Collections.Generic;

namespace gateway.Hubs.Clients {
    public interface IClockStreamClient{
        IAsyncEnumerable<long> StreamClock(CancellationToken cancellationToken);
    }

}