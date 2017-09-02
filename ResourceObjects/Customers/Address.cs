using System.Collections.Generic;

namespace eCatalog.Integration.Magento2.ResourceObjects.Customers
{
    public class Address
    {
        public int id { get; set; }
        public int customerId { get; set; }
        public Region region { get; set; }
        public int regionId { get; set; }
        public string countryId { get; set; }
        public List<string> street { get; set; }
        public string company { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public string postcode { get; set; }
        public string city { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public string vatId { get; set; }
        public bool defaultShipping { get; set; }
        public bool defaultBilling { get; set; }
        public ExtensionAttributes2 extensionAttributes { get; set; }
        public List<CustomAttribute> customAttributes { get; set; }
    }

    public class CustomAttribute
    {
        public string attributeCode { get; set; }
        public string value { get; set; }
    }

    public class ExtensionAttributes2
    {
    }
}