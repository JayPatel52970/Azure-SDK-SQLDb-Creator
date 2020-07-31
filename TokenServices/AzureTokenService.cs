using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;

namespace AzureSQLDBCreator.TokenServices
{
    public static class AzureTokenService
    {
        public static AzureCredentials GetAzureCredentials()
        {
            var subscriptionId = "3833f073-c643-4862-935b-d09d8baaa495";
            var appId = "37a48cda-b1cb-4d60-8eaa-f58f6bc6985b";
            var appSecret = "xOnTbK5Kzae1o-23-.2-MUQp.9okFmm7ru";
            var tenantId = "6c031f94-c402-433a-92d2-2d3ce8516da3";
            var environment = AzureEnvironment.AzureGlobalCloud;

            var credentials = new AzureCredentialsFactory().FromServicePrincipal(appId, appSecret, tenantId, environment);

            return credentials.WithDefaultSubscription(subscriptionId);
        }
    }

}
