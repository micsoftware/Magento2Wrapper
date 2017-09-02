using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.Customers
{
    public class CustomerRepository
    {
        [JsonProperty("customer")]
        public MagentoCustomer customer { get; set; }
        public string passwordHash { get; set; }
    }
}
