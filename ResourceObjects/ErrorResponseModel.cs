using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCatalog.Integration.Magento2.ResourceObjects
{
    public class ErrorResponseModel
    {
        public string message { get; set; }
        public List<Error> errors { get; set; }
        public int code { get; set; }
        public List<Parameter> parameters { get; set; }
        public string trace { get; set; }
    }

    public class Error
    {
        public string message { get; set; }
        public List<Parameter> parameters { get; set; }
    }

    public class Parameter
    {
        public string resources { get; set; }
        public string fieldName { get; set; }
        public string fieldValue { get; set; }
    }
}
