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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Synapse;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapsePrivateLinkHubResource
    {
        // Get a privateLinkHub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAPrivateLinkHub()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetPrivateLinkHub.json
            // this example is just showing the usage of "PrivateLinkHubs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapsePrivateLinkHubResource created on azure
            // for more information of creating SynapsePrivateLinkHubResource, please refer to the document of SynapsePrivateLinkHubResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup1";
            string privateLinkHubName = "privateLinkHub1";
            ResourceIdentifier synapsePrivateLinkHubResourceId = SynapsePrivateLinkHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateLinkHubName);
            SynapsePrivateLinkHubResource synapsePrivateLinkHub = client.GetSynapsePrivateLinkHubResource(synapsePrivateLinkHubResourceId);

            // invoke the operation
            SynapsePrivateLinkHubResource result = await synapsePrivateLinkHub.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapsePrivateLinkHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a privateLinkHub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAPrivateLinkHub()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/UpdatePrivateLinkHub.json
            // this example is just showing the usage of "PrivateLinkHubs_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapsePrivateLinkHubResource created on azure
            // for more information of creating SynapsePrivateLinkHubResource, please refer to the document of SynapsePrivateLinkHubResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup1";
            string privateLinkHubName = "privateLinkHub1";
            ResourceIdentifier synapsePrivateLinkHubResourceId = SynapsePrivateLinkHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateLinkHubName);
            SynapsePrivateLinkHubResource synapsePrivateLinkHub = client.GetSynapsePrivateLinkHubResource(synapsePrivateLinkHubResourceId);

            // invoke the operation
            SynapsePrivateLinkHubPatch patch = new SynapsePrivateLinkHubPatch()
            {
                Tags =
{
["key"] = "value",
},
            };
            SynapsePrivateLinkHubResource result = await synapsePrivateLinkHub.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapsePrivateLinkHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a privateLinkHub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAPrivateLinkHub()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DeletePrivateLinkHub.json
            // this example is just showing the usage of "PrivateLinkHubs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapsePrivateLinkHubResource created on azure
            // for more information of creating SynapsePrivateLinkHubResource, please refer to the document of SynapsePrivateLinkHubResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup1";
            string privateLinkHubName = "privateLinkHub1";
            ResourceIdentifier synapsePrivateLinkHubResourceId = SynapsePrivateLinkHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateLinkHubName);
            SynapsePrivateLinkHubResource synapsePrivateLinkHub = client.GetSynapsePrivateLinkHubResource(synapsePrivateLinkHubResourceId);

            // invoke the operation
            await synapsePrivateLinkHub.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // List privateLinkHubs in subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSynapsePrivateLinkHubs_ListPrivateLinkHubsInSubscription()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/ListPrivateLinkHubsInSubscription.json
            // this example is just showing the usage of "PrivateLinkHubs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SynapsePrivateLinkHubResource item in subscriptionResource.GetSynapsePrivateLinkHubsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapsePrivateLinkHubData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
