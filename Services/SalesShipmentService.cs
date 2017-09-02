using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCatalog.Integration.Magento2.Authorization;
using eCatalog.Integration.Magento2.Configuration;
using eCatalog.Integration.Magento2.ResourceObjects.Catalog;
using eCatalog.Integration.Magento2.ResourceObjects.Common;
using eCatalog.Integration.Magento2.ResourceObjects.Customers;
using eCatalog.Integration.Magento2.ResourceObjects.SalesShipment;
using RestSharp;

namespace eCatalog.Integration.Magento2.Services
{
    public class SalesShipmentService
    {
        private RestClient client;
        private readonly IAuthorizationService _authorizationService;

        public SalesShipmentService(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            client = new RestClient(AppConfig.BaseApiUrl);
        }


        public string GetSingleShipment(int shipmentId)
        {
            var request = new RestRequest($"V1/shipment/{shipmentId}", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }

        public string PostShipment(MagentoSalesShipment salesShipment)
        {
            var request = new RestRequest("V1/shipment/", Method.POST);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddBody(salesShipment);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetShipments(SearchCriteria searchCriteria)
        {
            var request = new RestRequest("V1/shipments", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddParameter("field", searchCriteria.filterGroups, ParameterType.QueryString);
            var response = client.Execute(request);
            return response.Content;
        }

    }
}
