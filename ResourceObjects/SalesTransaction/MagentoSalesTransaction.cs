using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.SalesTransaction
{
    [JsonObject("salestransaction")]
    public class MagentoSalesTransaction
    { 
        public int transactionId { get; set; }
        public int parentId { get; set; }
        public int orderId { get; set; }
        public int paymentId { get; set; }
        public string txnId { get; set; }
        public string parentTxnId { get; set; }
        public string txnType { get; set; }
        public int isClosed { get; set; }
        public List<string> additionalInformation { get; set; }
        public string createdAt { get; set; }
        public List<ChildTransaction> childTransactions { get; set; }
        public ExtensionAttributes extensionAttributes { get; set; }
    }
    public class ChildTransaction
    {
    }

    public class ExtensionAttributes
    {
    }

}

