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
    public class SalesTransactionService
    {
        private RestClient client;
        private readonly IAuthorizationService _authorizationService;

        public SalesTransactionService(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            client = new RestClient(AppConfig.BaseApiUrl);
        }

        public string GetSalesTransaction(int id)
        {
            var request = new RestRequest($"V1/transactions/{id}", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetSalesTransactions(SearchCriteria searchCriteria)
        {
            var request = new RestRequest("V1/transactions/", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            request.AddParameter("field", searchCriteria.filterGroups, ParameterType.QueryString);
            return response.Content;
        }
    }
}
