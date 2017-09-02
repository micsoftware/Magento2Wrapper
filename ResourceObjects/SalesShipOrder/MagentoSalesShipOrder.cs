using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.SalesShipOrder
{
    [JsonObject("salesshiporder")]
    public class MagentoSalesShipOrder
    {
        public List<Item> items { get; set; }
        public bool notify { get; set; }
        public bool appendComment { get; set; }
        public Comment comment { get; set; }
        public List<Track> tracks { get; set; }
        public List<Package> packages { get; set; }
        public Arguments arguments { get; set; }
    }
}
