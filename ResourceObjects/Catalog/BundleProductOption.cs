using System.Collections.Generic;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.Catalog
{
    public class BundleProductOption
    {
        public int optionId { get; set; }
        public string title { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public int position { get; set; }
        public string sku { get; set; }
        public List<ProductLink> productLinks { get; set; }

        [JsonProperty("extensionAttributes")]
        public BundleExtensionAttributes ExtensionAttributes { get; set; }
    }
}