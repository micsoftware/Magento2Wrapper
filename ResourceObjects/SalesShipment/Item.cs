namespace eCatalog.Integration.Magento2.ResourceObjects.SalesShipment
{
    public class Item
    {
        public string additionalData { get; set; }
        public string description { get; set; }
        public int entityId { get; set; }
        public string name { get; set; }
        public int parentId { get; set; }
        public int price { get; set; }
        public int productId { get; set; }
        public int rowTotal { get; set; }
        public string sku { get; set; }
        public int weight { get; set; }
        public ExtensionAttributes2 extensionAttributes { get; set; }
        public int orderItemId { get; set; }
        public int qty { get; set; }
    }
    public class ExtensionAttributes2
    {
    }
}