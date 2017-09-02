using System.Collections.Generic;
using eCatalog.Integration.Magento2.Models;
using eCatalog.Integration.Magento2.ResourceObjects.Common;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.Catalog
{
    public class CatalogProductSearchResult
    {
        [JsonProperty("items")]
        public List<MagentoProduct> items { get; set; }
        public SearchCriteria searchCriteria { get; set; }
        public int totalCount { get; set; }
    } 
  
}