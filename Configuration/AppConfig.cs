using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCatalog.Integration.Magento2.Configuration
{
    public static class AppConfig
    {
        public static string  BaseApiUrl { get; set; } = "http://13.91.251.131/index.php/rest";
        public static string TokenEndPoint => "V1/integration/admin/token";
        public static string AdminUser => "TestUser";
        public static string AdminPassword => "Gabzolee2000";

    }
}
