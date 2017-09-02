using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.SalesShipmentTrack
{
    public class SalesShipmentTracking
    {
        [JsonProperty("entity")]
        public MagentoSalesShipmentTracking entity { get; set; }

    }
}
