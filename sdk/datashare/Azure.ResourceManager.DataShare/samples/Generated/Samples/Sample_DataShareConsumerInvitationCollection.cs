// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DataShare;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_DataShareConsumerInvitationCollection
    {
        // ConsumerInvitations_ListInvitations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ConsumerInvitationsListInvitations()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ConsumerInvitations_ListInvitations.json
            // this example is just showing the usage of "ConsumerInvitations_ListInvitations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this DataShareConsumerInvitationResource
            DataShareConsumerInvitationCollection collection = tenantResource.GetDataShareConsumerInvitations();

            // invoke the operation and iterate over the result
            await foreach (DataShareConsumerInvitationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataShareConsumerInvitationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ConsumerInvitations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ConsumerInvitationsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ConsumerInvitations_Get.json
            // this example is just showing the usage of "ConsumerInvitations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this DataShareConsumerInvitationResource
            DataShareConsumerInvitationCollection collection = tenantResource.GetDataShareConsumerInvitations();

            // invoke the operation
            AzureLocation location = new AzureLocation("East US 2");
            Guid invitationId = Guid.Parse("dfbbc788-19eb-4607-a5a1-c74181bfff03");
            DataShareConsumerInvitationResource result = await collection.GetAsync(location, invitationId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataShareConsumerInvitationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConsumerInvitations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ConsumerInvitationsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/ConsumerInvitations_Get.json
            // this example is just showing the usage of "ConsumerInvitations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // get the collection of this DataShareConsumerInvitationResource
            DataShareConsumerInvitationCollection collection = tenantResource.GetDataShareConsumerInvitations();

            // invoke the operation
            AzureLocation location = new AzureLocation("East US 2");
            Guid invitationId = Guid.Parse("dfbbc788-19eb-4607-a5a1-c74181bfff03");
            bool result = await collection.ExistsAsync(location, invitationId);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
