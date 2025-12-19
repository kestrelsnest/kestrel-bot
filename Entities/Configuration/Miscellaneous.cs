using Microsoft.Extensions.Configuration;
using Kestrel.Bot.Helpers;

namespace Kestrel.Bot.Entities.Configuration
{
    public sealed class Miscellaneous
    {
        public string EmbedColor { get; private set; }

        public Miscellaneous(IConfigurationSection section)
        {
            EmbedColor = section.GetStrValue(nameof(EmbedColor));
        }
    }
}
