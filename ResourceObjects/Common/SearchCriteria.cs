using System.Collections.Generic;

namespace eCatalog.Integration.Magento2.ResourceObjects.Common
{
    public class SearchCriteria
    {
        public List<FilterGroup> filterGroups { get; set; }
        public List<SortOrder> sortOrders { get; set; }
        public int pageSize { get; set; }
        public int currentPage { get; set; }
    }
    public class Filter
    {
        public string field { get; set; }
        public string value { get; set; }
        public string conditionType { get; set; }
    }
    public class FilterGroup
    {
        public List<Filter> filters { get; set; }
    }

    public class SortOrder
    {
        public string field { get; set; }
        public string direction { get; set; }
    }
}