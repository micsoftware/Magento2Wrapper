namespace eCatalog.Integration.Magento2.Models
{
    public abstract class Content
    {
        public string base64EncodedData { get; set; }
        public string type { get; set; }
        public string name { get; set; }
    }
}