using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using eCatalog.Integration.Magento2.Authorization;
using eCatalog.Integration.Magento2.Configuration;
using eCatalog.Integration.Magento2.ResourceObjects.Customers;
using RestSharp;

namespace eCatalog.Integration.Magento2.Services
{
    public class CustomerService
    {
        private RestClient client;
        private readonly IAuthorizationService _authorizationService;

        public CustomerService(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            client = new RestClient(AppConfig.BaseApiUrl);
        }

        public string GetCustomer(int customerId)
        {
            var request = new RestRequest($"V1/customers/{customerId}", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }

        public string PostCustomer(MagentoCustomer customer)
        {
            var customerAccount = new CustomerAccount { customer = customer };
            var request = new RestRequest("V1/customers", Method.POST);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddBody(customerAccount);
            var response = client.Execute(request);
            return response.Content;
        }

        public string UpdateCustomer(int customerId, MagentoCustomer customer)
        {
            var customerRepository = new CustomerRepository { customer = customer };
            var request = new RestRequest($"V1/customers/{customerId}", Method.PUT);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            request.AddBody(customerRepository);
            var response = client.Execute(request);
            return response.Content;
        }
        public string DeleteCustomer(int customerId)
        {
            var request = new RestRequest($"V1/customers/{customerId}", Method.DELETE);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }

        public string GetCustomerBillingAddress(int customerId)
        {
            var request = new RestRequest($"V1/customers/{customerId}/billingAddress", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }
        public string GetCustomerShippingAddress(int customerId)
        {
            var request = new RestRequest($"V1/customers/{customerId}/shippingAddress", Method.GET);
            request.AddHeader("Authorization", "Bearer " + _authorizationService.AccessToken);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}
