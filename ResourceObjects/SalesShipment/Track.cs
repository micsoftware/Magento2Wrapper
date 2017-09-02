namespace eCatalog.Integration.Magento2.ResourceObjects.SalesShipment
{
    public class Track
    {
        public int orderId { get; set; }
        public string createdAt { get; set; }
        public int entityId { get; set; }
        public int parentId { get; set; }
        public string updatedAt { get; set; }
        public int weight { get; set; }
        public int qty { get; set; }
        public string description { get; set; }
        public ExtensionAttributes3 extensionAttributes { get; set; }
        public string trackNumber { get; set; }
        public string title { get; set; }
        public string carrierCode { get; set; }
    }

    public class ExtensionAttributes3
    {
    }
}