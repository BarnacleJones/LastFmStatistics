using LastFmStatistics.Service.Contract.Models;

namespace LastFmStatistics.Service.Contract
{
    public interface ICsvParser
    {
        List<Scrobble> GetScrobbles();
    }
}
