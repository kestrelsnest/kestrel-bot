namespace Kestrel.Bot.Entities
{
    public sealed class ServerStatus(bool dcsOnline, bool srsOnline)
    {
        public bool DcsOnline { get; private set; } = dcsOnline;
        public bool SrsOnline { get; private set; } = srsOnline;
    }
}
