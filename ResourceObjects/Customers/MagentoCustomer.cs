using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.Customers
{
    [JsonObject("customer")]
    public class MagentoCustomer
    {
        public int id { get; set; }
        public int groupId { get; set; }
        public string defaultBilling { get; set; }
        public string defaultShipping { get; set; }
        public string confirmation { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string createdIn { get; set; }
        public string dob { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int gender { get; set; }
        public int storeId { get; set; }
        public string taxvat { get; set; }
        [JsonProperty("website_id")]
        public int websiteId { get; set; }
        public List<Address> addresses { get; set; }
        public int disableAutoGroupChange { get; set; }
        public ExtensionAttributes3 extensionAttributes { get; set; }
        public List<CustomAttribute2> customAttributes { get; set; }
    }
    public class ExtensionAttributes3
    {
    }

    public class CustomAttribute2
    {
        public string attributeCode { get; set; }
        public string value { get; set; }
    }
}
