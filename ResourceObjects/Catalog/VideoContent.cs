namespace eCatalog.Integration.Magento2.Models
{
    public abstract class VideoContent
    {
        public string mediaType { get; set; }
        public string videoProvider { get; set; }
        public string videoUrl { get; set; }
        public string videoTitle { get; set; }
        public string videoDescription { get; set; }
        public string videoMetadata { get; set; }
    }
}