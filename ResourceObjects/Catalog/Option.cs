using System.Collections.Generic;

namespace eCatalog.Integration.Magento2.ResourceObjects.Catalog
{
    public abstract class Option
    {
        public string productSku { get; set; }
        public int optionId { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public int sortOrder { get; set; }
        public bool isRequire { get; set; }
        public int price { get; set; }
        public string priceType { get; set; }
        public string sku { get; set; }
        public string fileExtension { get; set; }
        public int maxCharacters { get; set; }
        public int imageSizeX { get; set; }
        public int imageSizeY { get; set; }
        public List<Value2> values { get; set; }
        public ExtensionAttributes14 extensionAttributes { get; set; }
    }
}