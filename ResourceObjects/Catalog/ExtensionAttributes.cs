using System.Collections.Generic;
using eCatalog.Integration.Magento2.Models;

namespace eCatalog.Integration.Magento2.ResourceObjects.Catalog
{
    public abstract class ExtensionAttributes
    {
        public List<DownloadableProductLink> downloadableProductLinks { get; set; }
        public List<DownloadableProductSample> downloadableProductSamples { get; set; }
        public StockItem stockItem { get; set; }
        public List<GiftcardAmount> giftcardAmounts { get; set; }
        public List<ConfigurableProductOption> configurableProductOptions { get; set; }
        public List<int> configurableProductLinks { get; set; }
        public List<BundleProductOption> bundleProductOptions { get; set; }
    }
}