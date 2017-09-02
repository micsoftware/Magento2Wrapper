namespace eCatalog.Integration.Magento2.ResourceObjects.SalesShipment
{
    public class Comment
    {
        public int isCustomerNotified { get; set; }
        public int parentId { get; set; }
        public ExtensionAttributes4 extensionAttributes { get; set; }
        public string comment { get; set; }
        public int isVisibleOnFront { get; set; }
        public string createdAt { get; set; }
        public int entityId { get; set; }
    }
    public class ExtensionAttributes4
    {
    }

}