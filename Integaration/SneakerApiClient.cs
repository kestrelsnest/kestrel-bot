using Kestrel.Bot.Entities.Integration.Sneaker;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kestrel.Bot.Integaration
{
    public sealed class SneakerApiClient
    {
        public async Task<IEnumerable<ServerInfoContract>> GetServerInfosAsync(string apiAdress)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", "Minsky");
            var byteResult = await client.GetStreamAsync(apiAdress);

            return await JsonSerializer.DeserializeAsync<IList<ServerInfoContract>>(byteResult);
        }
    }
}
