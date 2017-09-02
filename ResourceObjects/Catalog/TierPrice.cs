namespace eCatalog.Integration.Magento2.ResourceObjects.Catalog
{
    public abstract class TierPrice
    {
        public int customerGroupId { get; set; }
        public int qty { get; set; }
        public int value { get; set; }
        public ExtensionAttributes16 extensionAttributes { get; set; }
    }
}