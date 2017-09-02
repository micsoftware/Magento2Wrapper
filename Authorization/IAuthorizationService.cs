using eCatalog.Integration.Magento2.Authorization.Models;

namespace eCatalog.Integration.Magento2.Authorization
{
    public interface IAuthorizationService
    {
        string AccessToken { get; set; }
        string GetToken();
        string GetTokenAsync(LoginModel model);
    }
}