using CsvHelper.Configuration.Attributes;

namespace LastFmStatistics.Service.Contract.Models
{
    public class Scrobble
    {
        [Index(0)]
        public string Artist { get; set; }

        [Index(1)]
        public string Album{ get; set; }

        [Index(2)]
        public string Title { get; set; }

        [Index(3)]
        public DateTime? DateTime { get; set; }
    }
}
