using System;
using System.Threading;
using System.Threading.Tasks;
using ApiLibrary;

namespace ConsoleApp
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var baseUri = new Uri("http://localhost:5000");
            if (args.Length > 0 && !Uri.TryCreate(args[0], UriKind.Absolute, out baseUri))
            {
                Console.Error.WriteLine("usage: ConsoleApp [<baseUri>]");
                Environment.ExitCode = -1;
                return;
            }

            var api = new Api(baseUri);

            var cts = new CancellationTokenSource();
            Console.CancelKeyPress += (_, _) => cts.Cancel();

            Console.WriteLine("Getting uptime... (Ctrl+C to cancel)");
            var status = await api.GetStatusAsync(cts.Token);

            Console.WriteLine("Uptime is {0:g}", status.Uptime);
        }
    }
}
