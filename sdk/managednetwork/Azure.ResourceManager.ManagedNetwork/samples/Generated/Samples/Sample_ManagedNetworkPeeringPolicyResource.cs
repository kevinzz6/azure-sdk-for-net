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
using Azure.ResourceManager.ManagedNetwork;
using Azure.ResourceManager.ManagedNetwork.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ManagedNetwork.Samples
{
    public partial class Sample_ManagedNetworkPeeringPolicyResource
    {
        // ManagedNetworkPeeringPoliciesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ManagedNetworkPeeringPoliciesGet()
        {
            // Generated from example definition: specification/managednetwork/resource-manager/Microsoft.ManagedNetwork/preview/2019-06-01-preview/examples/ManagedNetworkPeeringPolicy/ManagedNetworkPeeringPoliciesGet.json
            // this example is just showing the usage of "ManagedNetworkPeeringPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedNetworkPeeringPolicyResource created on azure
            // for more information of creating ManagedNetworkPeeringPolicyResource, please refer to the document of ManagedNetworkPeeringPolicyResource
            string subscriptionId = "subscriptionA";
            string resourceGroupName = "myResourceGroup";
            string managedNetworkName = "myManagedNetwork";
            string managedNetworkPeeringPolicyName = "myHubAndSpoke";
            ResourceIdentifier managedNetworkPeeringPolicyResourceId = ManagedNetworkPeeringPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedNetworkName, managedNetworkPeeringPolicyName);
            ManagedNetworkPeeringPolicyResource managedNetworkPeeringPolicy = client.GetManagedNetworkPeeringPolicyResource(managedNetworkPeeringPolicyResourceId);

            // invoke the operation
            ManagedNetworkPeeringPolicyResource result = await managedNetworkPeeringPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedNetworkPeeringPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ManagedNetworkPeeringPoliciesPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ManagedNetworkPeeringPoliciesPut()
        {
            // Generated from example definition: specification/managednetwork/resource-manager/Microsoft.ManagedNetwork/preview/2019-06-01-preview/examples/ManagedNetworkPeeringPolicy/ManagedNetworkPeeringPoliciesPut.json
            // this example is just showing the usage of "ManagedNetworkPeeringPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedNetworkPeeringPolicyResource created on azure
            // for more information of creating ManagedNetworkPeeringPolicyResource, please refer to the document of ManagedNetworkPeeringPolicyResource
            string subscriptionId = "subscriptionA";
            string resourceGroupName = "myResourceGroup";
            string managedNetworkName = "myManagedNetwork";
            string managedNetworkPeeringPolicyName = "myHubAndSpoke";
            ResourceIdentifier managedNetworkPeeringPolicyResourceId = ManagedNetworkPeeringPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedNetworkName, managedNetworkPeeringPolicyName);
            ManagedNetworkPeeringPolicyResource managedNetworkPeeringPolicy = client.GetManagedNetworkPeeringPolicyResource(managedNetworkPeeringPolicyResourceId);

            // invoke the operation
            ManagedNetworkPeeringPolicyData data = new ManagedNetworkPeeringPolicyData()
            {
                Properties = new ManagedNetworkPeeringPolicyProperties(ConnectivityType.HubAndSpokeTopology)
                {
                    HubId = new ResourceIdentifier("/subscriptionB/resourceGroups/myResourceGroup/providers/Microsoft.Network/virtualNetworks/myHubVnet"),
                    Spokes =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptionB/resourceGroups/myResourceGroup/providers/Microsoft.ManagedNetwork/managedNetworks/myManagedNetwork/managedNetworkGroups/myManagedNetworkGroup1"),
}
},
                },
            };
            ArmOperation<ManagedNetworkPeeringPolicyResource> lro = await managedNetworkPeeringPolicy.UpdateAsync(WaitUntil.Completed, data);
            ManagedNetworkPeeringPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedNetworkPeeringPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ManagedNetworkPeeringPoliciesDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ManagedNetworkPeeringPoliciesDelete()
        {
            // Generated from example definition: specification/managednetwork/resource-manager/Microsoft.ManagedNetwork/preview/2019-06-01-preview/examples/ManagedNetworkPeeringPolicy/ManagedNetworkPeeringPoliciesDelete.json
            // this example is just showing the usage of "ManagedNetworkPeeringPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedNetworkPeeringPolicyResource created on azure
            // for more information of creating ManagedNetworkPeeringPolicyResource, please refer to the document of ManagedNetworkPeeringPolicyResource
            string subscriptionId = "subscriptionA";
            string resourceGroupName = "myResourceGroup";
            string managedNetworkName = "myManagedNetwork";
            string managedNetworkPeeringPolicyName = "myHubAndSpoke";
            ResourceIdentifier managedNetworkPeeringPolicyResourceId = ManagedNetworkPeeringPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedNetworkName, managedNetworkPeeringPolicyName);
            ManagedNetworkPeeringPolicyResource managedNetworkPeeringPolicy = client.GetManagedNetworkPeeringPolicyResource(managedNetworkPeeringPolicyResourceId);

            // invoke the operation
            await managedNetworkPeeringPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
