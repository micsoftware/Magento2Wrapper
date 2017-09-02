using System.Collections.Generic;
using eCatalog.Integration.Magento2.Models;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.Catalog
{
    [JsonObject("product")]
    public class MagentoProduct
    {
        public int id { get; set; }
        public string sku { get; set; }
        public string name { get; set; }

        [JsonProperty("attribute_set_id")]
        public int attributeSetId { get; set; }
        public double price { get; set; }
        public int status { get; set; }
        public int visibility { get; set; }

        [JsonProperty("type_id")]
        public string typeId { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public int weight { get; set; }
        public ExtensionAttributes extensionAttributes { get; set; }
        public List<ProductLink2> productLinks { get; set; }
        public List<Option> options { get; set; }
        public List<MediaGalleryEntry> mediaGalleryEntries { get; set; }
        public List<TierPrice> tierPrices { get; set; }
        public List<CustomAttribute> customAttributes { get; set; }
    }
    public abstract class ExtensionAttributes2
    {
    }

    public abstract class ExtensionAttributes3
    {
    }

    public class SampleFileContent
    {
        public string fileData { get; set; }
        public string name { get; set; }
        public ExtensionAttributes3 extensionAttributes { get; set; }
    }

    public class DownloadableProductLinkExtensionAttributes
    {
    }

    public class DownloadableProductLink
    {
        public int id { get; set; }
        public string title { get; set; }
        public int sortOrder { get; set; }
        public int isShareable { get; set; }
        public int price { get; set; }
        public int numberOfDownloads { get; set; }
        public string linkType { get; set; }
        public string linkFile { get; set; }
        public LinkFileContent linkFileContent { get; set; }
        public string linkUrl { get; set; }
        public string sampleType { get; set; }
        public string sampleFile { get; set; }
        public SampleFileContent sampleFileContent { get; set; }
        public string sampleUrl { get; set; }

        [JsonProperty("extensionAttributes")]
        public DownloadableProductLinkExtensionAttributes extensionAttributes { get; set; }
    }

    public class ExtensionAttributes5
    {
    }

    public class SampleFileContent2
    {
        public string fileData { get; set; }
        public string name { get; set; }
        public ExtensionAttributes5 extensionAttributes { get; set; }
    }

    public class ExtensionAttributes6
    {
    }

    public class DownloadableProductSample
    {
        public int id { get; set; }
        public string title { get; set; }
        public int sortOrder { get; set; }
        public string sampleType { get; set; }
        public string sampleFile { get; set; }
        public SampleFileContent2 sampleFileContent { get; set; }
        public string sampleUrl { get; set; }
        public ExtensionAttributes6 extensionAttributes { get; set; }
    }

    public class ExtensionAttributes7
    {
    }

    public class ExtensionAttributes8
    {
    }

    public class ExtensionAttributes9
    {
    }

    public class Value
    {
        public int valueIndex { get; set; }
        public ExtensionAttributes9 extensionAttributes { get; set; }
    }

    public class ConfigurableProductOptionExtensionAttributes
    {
    }

    public class ConfigurableProductOption
    {
        public int id { get; set; }
        public string attributeId { get; set; }
        public string label { get; set; }
        public int position { get; set; }
        public bool isUseDefault { get; set; }
        public List<Value> values { get; set; }

        [JsonProperty("extensionAttributes")]
        public ConfigurableProductOptionExtensionAttributes extensionAttributes { get; set; }

        public int productId { get; set; }
    }

    public class ExtensionAttributes11
    {
    }

    public class BundleExtensionAttributes
    {
    }

    public class ExtensionAttributes13
    {
        public int qty { get; set; }
    }

    public class ProductLink2
    {
        public string sku { get; set; }
        public string linkType { get; set; }
        public string linkedProductSku { get; set; }
        public string linkedProductType { get; set; }
        public int position { get; set; }
        public ExtensionAttributes13 extensionAttributes { get; set; }
    }

    public class Value2
    {
        public string title { get; set; }
        public int sortOrder { get; set; }
        public int price { get; set; }
        public string priceType { get; set; }
        public string sku { get; set; }
        public int optionTypeId { get; set; }
    }

    public class ExtensionAttributes14
    {
    }
    
    public class ExtensionAttributes16
    {
    }
}
