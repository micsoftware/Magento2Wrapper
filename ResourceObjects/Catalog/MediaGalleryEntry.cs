using System.Collections.Generic;
using eCatalog.Integration.Magento2.Models;
using Newtonsoft.Json;

namespace eCatalog.Integration.Magento2.ResourceObjects.Catalog
{
    public class MediaGalleryEntry
    {
        public int id { get; set; }
        public string mediaType { get; set; }
        public string label { get; set; }
        public int position { get; set; }
        public bool disabled { get; set; }
        public List<string> types { get; set; }
        public string file { get; set; }
        public Content content { get; set; }

        [JsonProperty("extensionAttributes")]
        public MediaGalleryEntryExtensionAttributes extensionAttributes { get; set; }

        public class MediaGalleryEntryExtensionAttributes
        {
            public VideoContent videoContent { get; set; }
        }
    }
}