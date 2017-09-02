using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCatalog.Integration.Magento2.Authorization;
using eCatalog.Integration.Magento2.Configuration;
using eCatalog.Integration.Magento2.ResourceObjects.SalesShipmentTrack;
using RestSharp;

namespace eCatalog.Integration.Magento2.Services
{
    public class SalesShipmentTrackingService
    {
        private RestClient client;
        private readonly IAuthorizationService _authorizationService;

        public SalesShipmentTrackingService(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            client = new RestClient(AppConfig.BaseApiUrl);
        }

        public string AddSalesShipmentTracking(MagentoSalesShipmentTracking entity)
        {
            var trackShipment = new SalesShipmentTracking { entity = entity };
            var request = new RestRequest("V1/shipment/track", Method.POST);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddBody(trackShipment);
            var response = client.Execute(request);
            return response.Content;
        }


        public string DeleteSalesShipmentTracking(int trackingShipmentId)
        {
            var request = new RestRequest($"V1/shipment/track/{trackingShipmentId}", Method.DELETE);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
