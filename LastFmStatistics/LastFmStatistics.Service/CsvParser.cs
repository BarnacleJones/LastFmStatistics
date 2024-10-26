using CsvHelper;
using LastFmStatistics.Service.Contract;
using LastFmStatistics.Service.Contract.Models;
using System.Globalization;

namespace LastFmStatistics.Service
{
    public class CsvParser : ICsvParser
    {
        public List<Scrobble> GetScrobbles()
        {
            var data = new List<Scrobble>();
            using (var reader = new StreamReader("C:\\Users\\Ben\\Downloads\\SteinyMchoodle.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Scrobble>();
                data.AddRange(records);
            }
            return data;
        }
    }
}
