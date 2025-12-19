using Discord;
using Discord.Interactions;
using Kestrel.Bot.Services;
using System.Drawing;
using System.Threading.Tasks;

namespace Kestrel.Bot.Modules.Base
{
    public class SlashCommandModuleBase : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly ConfigurationService _configService;

        public SlashCommandModuleBase(ConfigurationService configurationService)
        {
            _configService = configurationService;
        }

        protected EmbedBuilder GetDefaultEmbedBuilder()
        {
            var embedColor = (System.Drawing.Color)new ColorConverter().ConvertFromString(_configService.Miscellaneous.EmbedColor);
            return new EmbedBuilder
            {
                Color = new Discord.Color(embedColor.R, embedColor.G, embedColor.B),
            };
        }

        protected async Task RespondAsync(EmbedBuilder builder) => await Context.Interaction.RespondAsync(embed: builder.Build());
    }
}
