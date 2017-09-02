using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace eCatalog.Integration.Magento2.ResourceObjects.Customers
{
    public class CustomerAccount
    {
        [JsonProperty("customer")]
        public MagentoCustomer customer { get; set; }

        public string password { get; set; }
        public string redirectUrl { get; set; }

    }
}
