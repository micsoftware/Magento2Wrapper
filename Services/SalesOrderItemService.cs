using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCatalog.Integration.Magento2.Authorization;
using eCatalog.Integration.Magento2.Configuration;
using eCatalog.Integration.Magento2.ResourceObjects.Common;
using RestSharp;

namespace eCatalog.Integration.Magento2.Services
{
    public class SalesOrderItemService
    {
        private RestClient client;
        private readonly IAuthorizationService _authorizationService;

        public SalesOrderItemService(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            client = new RestClient(AppConfig.BaseApiUrl);
        }

        public string GetSalesOrderItem(int id)
        {
            var request = new RestRequest($"V1/orders/items/{id}", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetSalesOrderItems(SearchCriteria searchCriteria)
        {
            var request = new RestRequest("V1/orders/items", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddParameter("field", searchCriteria.filterGroups, ParameterType.QueryString);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
