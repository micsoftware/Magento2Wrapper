using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCatalog.Integration.Magento2.Authorization;
using eCatalog.Integration.Magento2.Configuration;
using RestSharp;

namespace eCatalog.Integration.Magento2.Services
{
    public class SalesOrderManagementService
    {
        private RestClient client;
        private readonly IAuthorizationService _authorizationService;

        public SalesOrderManagementService(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            client = new RestClient(AppConfig.BaseApiUrl);
        }

        public string GetOrderStatuses(int id)
        {
            var request = new RestRequest($"V1/orders/{id}/statuses", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }

        public string CancelOrder(int id)
        {
            var request = new RestRequest($"V1/orders/{id}/cancel", Method.POST);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }


        public string EmailOrder(int id)
        {
            var request = new RestRequest($"V1/orders/{id}/emails", Method.POST);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }

        public string HoldOrder(int id)
        {
            var request = new RestRequest($"V1/orders/{id}/hold", Method.POST);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }

        public string UnHoldOrder(int id)
        {
            var request = new RestRequest($"V1/orders/{id}/unhold", Method.POST);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }

    }
}
