using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.SalesShipmentTrack
{
    [JsonObject("shipmentTrack")]
    public class MagentoSalesShipmentTracking
    {

        public int orderId { get; set; }
        public string createdAt { get; set; }
        public int entityId { get; set; }
        public int parentId { get; set; }
        public string updatedAt { get; set; }
        public int weight { get; set; }
        public int qty { get; set; }
        public string description { get; set; }
        public ExtensionAttributes extensionAttributes { get; set; }
        public string trackNumber { get; set; }
        public string title { get; set; }
        public string carrierCode { get; set; }
    }
    public class ExtensionAttributes
    {
    }
}