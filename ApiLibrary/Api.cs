using System;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using NetworkLibrary;

namespace ApiLibrary
{
    public class Api
    {
        private readonly Uri _baseUri;
        private readonly HttpUtils _network;

        public Api(Uri baseUri)
        {
            _baseUri = baseUri;
            _network = new HttpUtils();
        }

        public async Task<ApiStatus> GetStatusAsync(CancellationToken ct = default)
        {
            var statusUri = new Uri(_baseUri, "api/status");
            var status = await _network.SendWithRetry<StatusResponse>(HttpMethod.Get, statusUri, ct);
            return new ApiStatus(status.Uptime);
        }

        private class StatusResponse
        {
            [JsonPropertyName("uptime")]
            public long Uptime { get; set; }
        }
    }

    public class ApiStatus
    {
        public ApiStatus(long uptimeMilliseconds)
        {
            Uptime = TimeSpan.FromMilliseconds(uptimeMilliseconds);
        }
        
        public TimeSpan Uptime { get; }
    }
}
