// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_TenantAccessInfoResource
    {
        // ApiManagementHeadTenantAccess
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadTenantAccess()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementHeadTenantAccess.json
            // this example is just showing the usage of "TenantAccess_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantAccessInfoResource created on azure
            // for more information of creating TenantAccessInfoResource, please refer to the document of TenantAccessInfoResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            AccessName accessName = AccessName.TenantAccess;
            ResourceIdentifier tenantAccessInfoResourceId = TenantAccessInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, accessName);
            TenantAccessInfoResource tenantAccessInfo = client.GetTenantAccessInfoResource(tenantAccessInfoResourceId);

            // invoke the operation
            bool result = await tenantAccessInfo.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetTenantAccess
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetTenantAccess()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetTenantAccess.json
            // this example is just showing the usage of "TenantAccess_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantAccessInfoResource created on azure
            // for more information of creating TenantAccessInfoResource, please refer to the document of TenantAccessInfoResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            AccessName accessName = AccessName.TenantAccess;
            ResourceIdentifier tenantAccessInfoResourceId = TenantAccessInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, accessName);
            TenantAccessInfoResource tenantAccessInfo = client.GetTenantAccessInfoResource(tenantAccessInfoResourceId);

            // invoke the operation
            TenantAccessInfoResource result = await tenantAccessInfo.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TenantAccessInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetTenantGitAccess
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetTenantGitAccess()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementGetTenantGitAccess.json
            // this example is just showing the usage of "TenantAccess_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantAccessInfoResource created on azure
            // for more information of creating TenantAccessInfoResource, please refer to the document of TenantAccessInfoResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            AccessName accessName = AccessName.TenantGitAccess;
            ResourceIdentifier tenantAccessInfoResourceId = TenantAccessInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, accessName);
            TenantAccessInfoResource tenantAccessInfo = client.GetTenantAccessInfoResource(tenantAccessInfoResourceId);

            // invoke the operation
            TenantAccessInfoResource result = await tenantAccessInfo.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TenantAccessInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementUpdateTenantAccess
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementUpdateTenantAccess()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementUpdateTenantAccess.json
            // this example is just showing the usage of "TenantAccess_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantAccessInfoResource created on azure
            // for more information of creating TenantAccessInfoResource, please refer to the document of TenantAccessInfoResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            AccessName accessName = AccessName.TenantAccess;
            ResourceIdentifier tenantAccessInfoResourceId = TenantAccessInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, accessName);
            TenantAccessInfoResource tenantAccessInfo = client.GetTenantAccessInfoResource(tenantAccessInfoResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            TenantAccessInfoPatch patch = new TenantAccessInfoPatch()
            {
                IsDirectAccessEnabled = true,
            };
            TenantAccessInfoResource result = await tenantAccessInfo.UpdateAsync(ifMatch, patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TenantAccessInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementTenantAccessRegenerateKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegeneratePrimaryKey_ApiManagementTenantAccessRegenerateKey()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementTenantAccessRegenerateKey.json
            // this example is just showing the usage of "TenantAccess_RegeneratePrimaryKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantAccessInfoResource created on azure
            // for more information of creating TenantAccessInfoResource, please refer to the document of TenantAccessInfoResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            AccessName accessName = AccessName.TenantAccess;
            ResourceIdentifier tenantAccessInfoResourceId = TenantAccessInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, accessName);
            TenantAccessInfoResource tenantAccessInfo = client.GetTenantAccessInfoResource(tenantAccessInfoResourceId);

            // invoke the operation
            await tenantAccessInfo.RegeneratePrimaryKeyAsync();

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementTenantAccessRegenerateKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateSecondaryKey_ApiManagementTenantAccessRegenerateKey()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementTenantAccessRegenerateKey.json
            // this example is just showing the usage of "TenantAccess_RegenerateSecondaryKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantAccessInfoResource created on azure
            // for more information of creating TenantAccessInfoResource, please refer to the document of TenantAccessInfoResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            AccessName accessName = AccessName.TenantAccess;
            ResourceIdentifier tenantAccessInfoResourceId = TenantAccessInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, accessName);
            TenantAccessInfoResource tenantAccessInfo = client.GetTenantAccessInfoResource(tenantAccessInfoResourceId);

            // invoke the operation
            await tenantAccessInfo.RegenerateSecondaryKeyAsync();

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementListSecretsTenantAccess
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSecrets_ApiManagementListSecretsTenantAccess()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementListSecretsTenantAccess.json
            // this example is just showing the usage of "TenantAccess_ListSecrets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantAccessInfoResource created on azure
            // for more information of creating TenantAccessInfoResource, please refer to the document of TenantAccessInfoResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            AccessName accessName = AccessName.TenantAccess;
            ResourceIdentifier tenantAccessInfoResourceId = TenantAccessInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, accessName);
            TenantAccessInfoResource tenantAccessInfo = client.GetTenantAccessInfoResource(tenantAccessInfoResourceId);

            // invoke the operation
            TenantAccessInfoSecretsDetails result = await tenantAccessInfo.GetSecretsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementTenantAccessRegenerateKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegeneratePrimaryKeyForGit_ApiManagementTenantAccessRegenerateKey()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementTenantAccessRegenerateKey.json
            // this example is just showing the usage of "TenantAccessGit_RegeneratePrimaryKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantAccessInfoResource created on azure
            // for more information of creating TenantAccessInfoResource, please refer to the document of TenantAccessInfoResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            AccessName accessName = AccessName.TenantAccess;
            ResourceIdentifier tenantAccessInfoResourceId = TenantAccessInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, accessName);
            TenantAccessInfoResource tenantAccessInfo = client.GetTenantAccessInfoResource(tenantAccessInfoResourceId);

            // invoke the operation
            await tenantAccessInfo.RegeneratePrimaryKeyForGitAsync();

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementTenantAccessRegenerateKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateSecondaryKeyForGit_ApiManagementTenantAccessRegenerateKey()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2021-08-01/examples/ApiManagementTenantAccessRegenerateKey.json
            // this example is just showing the usage of "TenantAccessGit_RegenerateSecondaryKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantAccessInfoResource created on azure
            // for more information of creating TenantAccessInfoResource, please refer to the document of TenantAccessInfoResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            AccessName accessName = AccessName.TenantAccess;
            ResourceIdentifier tenantAccessInfoResourceId = TenantAccessInfoResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, accessName);
            TenantAccessInfoResource tenantAccessInfo = client.GetTenantAccessInfoResource(tenantAccessInfoResourceId);

            // invoke the operation
            await tenantAccessInfo.RegenerateSecondaryKeyForGitAsync();

            Console.WriteLine($"Succeeded");
        }
    }
}
