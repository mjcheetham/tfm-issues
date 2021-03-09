using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace NetworkLibrary
{
    public class HttpUtils
    {
        private readonly HttpClient _httpClient;

        public HttpUtils()
        {
            _httpClient = new HttpClient();
        }

        public async Task<T> SendWithRetry<T>(HttpMethod method, Uri requestUri, CancellationToken ct = default)
        {
            while (true)
            {
                using var request = new HttpRequestMessage(method, requestUri);
                try
                {
                    using var response = await _httpClient.SendAsync(request, ct);
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<T>(cancellationToken: ct);
                    }
                }
                catch (HttpRequestException)
                {
                    // swallow
                }

                TimeSpan retryInterval =
                    IsOnMainsPower()
                        ? TimeSpan.FromSeconds(1)
                        : TimeSpan.FromSeconds(30);

                await Task.Delay(retryInterval, ct);
            }
        }

        private static bool IsOnMainsPower()
        {
#if WINDOWS10
            return Windows.System.Power.PowerManager.BatteryStatus != Windows.System.Power.BatteryStatus.Discharging;
#else
            return true; // Assume mains power is present
#endif
        }
    }
}
