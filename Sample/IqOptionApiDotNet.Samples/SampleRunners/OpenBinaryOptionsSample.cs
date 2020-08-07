using System;
using System.Threading.Tasks;
using IqOptionApiDotNet.Models;

namespace IqOptionApiDotNet.Samples.SampleRunners
{
    public class OpenBinaryOptionsSample : SampleRunner
    {
        public override async Task RunSample()
        {
            if (await IqClientApiDotNet.ConnectAsync())
            {
                while (true)
                {
                    await Task.Delay(5000);

                    var result = await IqClientApiDotNet.BuyAsync(ActivePair.EURUSD_OTC, 1, OrderDirection.Call,
                        DateTimeOffset.Now);

                    Console.WriteLine($"PositionId = {result.PositionId}");
                }
            }
        }
    }
}