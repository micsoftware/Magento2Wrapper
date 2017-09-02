using eCatalog.Integration.Magento2.Models;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.Catalog
{
    public class CatalogProduct
    {
        [JsonProperty("product")]
        public MagentoProduct product { get; set; }
        public bool saveOptions { get; set; }
    }
}