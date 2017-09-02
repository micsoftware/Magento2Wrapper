using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCatalog.Integration.Magento2.Authorization;
using eCatalog.Integration.Magento2.Configuration;
using eCatalog.Integration.Magento2.ResourceObjects.SalesShipOrder;
using RestSharp;

namespace eCatalog.Integration.Magento2.Services
{
    public class SalesShipOrderService
    {
        private RestClient client;
        private readonly IAuthorizationService _authorizationService;

        public SalesShipOrderService(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            client = new RestClient(AppConfig.BaseApiUrl);
        }


        public string AddSalesShippingOrder(int orderId, MagentoSalesShipOrder salesShipOrder)
        {
            var request = new RestRequest($"V1/order/{orderId}/ship", Method.POST);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddBody(salesShipOrder);
            var response = client.Execute(request);
            return response.Content;
        } 
    }
}
