using Microsoft.Extensions.Configuration;
using Kestrel.Bot.Helpers;

namespace Kestrel.Bot.Entities.Configuration
{
    public sealed class PortConfig
    {
        public string Ip { get; private set; }
        public int Port { get; private set; }

        public PortConfig(IConfigurationSection section)
        {
            Ip = section.GetStrValue(nameof(Ip));
            Port = section.GetIntValue(nameof(Port));
        }
    }
}