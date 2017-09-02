using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCatalog.Integration.Magento2.Authorization;
using eCatalog.Integration.Magento2.Configuration;
using eCatalog.Integration.Magento2.Models;
using eCatalog.Integration.Magento2.ResourceObjects.Catalog;
using eCatalog.Integration.Magento2.ResourceObjects.Common;
using Newtonsoft.Json;
using RestSharp;

namespace eCatalog.Integration.Magento2.Services
{
    public class ProductService
    {
        private RestClient client;
        private readonly IAuthorizationService _authorizationService;
        public ProductService(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            client = new RestClient(AppConfig.BaseApiUrl);
        }

        public string GetProducts(SearchCriteria searchCriteria)
        {
            var request = new RestRequest("V1/products", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddParameter("field", searchCriteria.filterGroups, ParameterType.QueryString);
            var response = client.Execute(request);
            return response.Content;
        }

        public MagentoProduct GetProduct(string sku, int storeId = 0, bool editMode = false, bool forceReload = false)
        {
            var request = new RestRequest($"V1/products/{sku}", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddParameter("storeId", storeId, ParameterType.QueryString);
            request.AddParameter("editMode", editMode, ParameterType.QueryString);
            request.AddParameter("forceReload", forceReload, ParameterType.QueryString);
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<MagentoProduct>(response.Content);
        }

        public string AddProduct(MagentoProduct product)
        {
            var catalog = new CatalogProduct {product = product};
            var request = new RestRequest("V1/products", Method.POST);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddBody(catalog);
            var response = client.Execute(request);
            return response.Content;
        }

        public string UpdateProduct(string sku, MagentoProduct product)
        {
            var catalog = new CatalogProduct { product = product };
            var request = new RestRequest($"V1/products/{product.sku}", Method.PUT);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddBody(catalog);
            var response = client.Execute(request);
            return response.Content;
        }

        public string DeleteProduct(string sku)
        {
            var request = new RestRequest($"V1/products/{sku}", Method.DELETE);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }
    
    }
}
