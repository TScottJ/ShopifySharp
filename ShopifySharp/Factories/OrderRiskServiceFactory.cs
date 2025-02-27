#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IOrderRiskServiceFactory
{
    /// Creates a new instance of the <see cref="IOrderRiskService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IOrderRiskService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IOrderRiskService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IOrderRiskService Create(ShopifyApiCredentials credentials);
}

public class OrderRiskServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IOrderRiskServiceFactory
{
    /// <inheritDoc />
    public virtual IOrderRiskService Create(string shopDomain, string accessToken)
    {
        IOrderRiskService service = shopifyDomainUtility is null ? new OrderRiskService(shopDomain, accessToken) : new OrderRiskService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IOrderRiskService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
