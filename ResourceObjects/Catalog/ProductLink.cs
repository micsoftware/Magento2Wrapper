namespace eCatalog.Integration.Magento2.ResourceObjects.Catalog
{
    public class ProductLink
    {
        public string id { get; set; }
        public string sku { get; set; }
        public int optionId { get; set; }
        public int qty { get; set; }
        public int position { get; set; }
        public bool isDefault { get; set; }
        public int price { get; set; }
        public int priceType { get; set; }
        public int canChangeQuantity { get; set; }
        public ExtensionAttributes11 extensionAttributes { get; set; }
    }
}