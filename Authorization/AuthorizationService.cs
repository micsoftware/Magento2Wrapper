using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCatalog.Integration.Magento2.Authorization.Models;
using eCatalog.Integration.Magento2.Configuration;
using Newtonsoft.Json;
using RestSharp;

namespace eCatalog.Integration.Magento2.Authorization
{
    public class AuthorizationService : IAuthorizationService
    {
        public string AccessToken { get; set; }

        public AuthorizationService()
        {
            if(string.IsNullOrEmpty(AppConfig.BaseApiUrl))
                throw new Exception("Base API Address property is null. Please provide a base address");
        }

        public string GetToken()
        {
            var model = new LoginModel
            {
                Username = AppConfig.AdminUser,
                Password = AppConfig.AdminPassword
            };
            var loginModelString = JsonConvert.SerializeObject(model);

            var client = new RestClient(AppConfig.BaseApiUrl);
            var request = new RestRequest(AppConfig.TokenEndPoint, Method.POST);
            request.Parameters.Clear();
            request.AddParameter("application/json", loginModelString, ParameterType.RequestBody);

            var response = client.Execute(request);
            var token = response.Content;
            //remove quotes from token string
            AccessToken = token.Replace("\"", string.Empty).Trim();
            return AccessToken;
        }

        public string GetTokenAsync(LoginModel model)
        {
            var loginModelString = JsonConvert.SerializeObject(model);

            var client = new RestClient(AppConfig.BaseApiUrl);
            var request = new RestRequest(AppConfig.TokenEndPoint, Method.POST);
            request.Parameters.Clear();
            request.AddParameter("application/json", loginModelString, ParameterType.RequestBody);

            var token = string.Empty;

            client.ExecuteAsync(request, response =>{
                token = response.Content;
            });

            //remove quotes from token string
            AccessToken = token.Replace("\"", string.Empty).Trim();
            return AccessToken;
        }
    }
}
