using Microsoft.Extensions.Configuration;
using Kestrel.Bot.Entities.Configuration;
using Kestrel.Bot.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Kestrel.Bot.Services
{
    public class ConfigurationService
    {
        private readonly IConfiguration _configuration;

        public ulong MasterUserId => ulong.Parse(_configuration.GetStrValue(nameof(MasterUserId)));
        public ulong DevStaffRoleId => ulong.Parse(_configuration.GetStrValue(nameof(DevStaffRoleId)));
        public string SneakerApiAdress => _configuration.GetStrValue(nameof(SneakerApiAdress));

        public string GciLinkTitle => _configuration.GetStrValue(nameof(GciLinkTitle));
        public string GciLinkUri => _configuration.GetStrValue(nameof(GciLinkUri));

        public string AboutLinkTitle => _configuration.GetStrValue(nameof(AboutLinkTitle));
        public string AboutLinkUri => _configuration.GetStrValue(nameof(AboutLinkUri));

        public Miscellaneous Miscellaneous => new(_configuration.GetSection(nameof(Miscellaneous)));
        public IEnumerable<ServerConfiguration> Servers => _configuration.GetSection(nameof(Servers)).GetChildren().Select(s => new ServerConfiguration(s));

        public ConfigurationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
