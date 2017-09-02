using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCatalog.Integration.Magento2.ResourceObjects.SalesShipment
{
    public class MagentoSalesShipment
    {
        public int billingAddressId { get; set; }
        public string createdAt { get; set; }
        public int customerId { get; set; }
        public int emailSent { get; set; }
        public int entityId { get; set; }
        public string incrementId { get; set; }
        public int orderId { get; set; }
        public List<Package> packages { get; set; }
        public int shipmentStatus { get; set; }
        public int shippingAddressId { get; set; }
        public string shippingLabel { get; set; }
        public int storeId { get; set; }
        public int totalQty { get; set; }
        public int totalWeight { get; set; }
        public string updatedAt { get; set; }
        public List<Item> items { get; set; }
        public List<Track> tracks { get; set; }
        public List<Comment> comments { get; set; }
        public ExtensionAttributes5 extensionAttributes { get; set; }
    }
    public class ExtensionAttributes5
    {
    }
}