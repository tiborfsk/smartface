using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SmartFace.Cli.Core.ApiAbstraction.Models
{
    public class RegisterWlItemImageData
    {
        public byte[] Data { get; set; }

        public string MIME { get; set; }
    }

    public class RegisterWlItemData
    {
        public string ExternalId { get; set; }

        public string DisplayName { get; set; }
       
        public string FullName { get; set; }

        public string Note { get; set; }

        public ICollection<RegisterWlItemImageData> ImageData { get; set; } = new Collection<RegisterWlItemImageData>();

        public ICollection<string> WatchlistExternalIds { get; set; } = new Collection<string>();
    }
}