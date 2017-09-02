namespace eCatalog.Integration.Magento2.ResourceObjects.Catalog
{
    public abstract class LinkFileContent
    {
        public string fileData { get; set; }
        public string name { get; set; }
        public ExtensionAttributes2 extensionAttributes { get; set; }
    }
}