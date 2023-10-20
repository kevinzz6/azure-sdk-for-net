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
using Azure.ResourceManager.RecoveryServicesSiteRecovery;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_ReplicationProtectionIntentCollection
    {
        // Gets the list of replication protection intent objects.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetsTheListOfReplicationProtectionIntentObjects()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationProtectionIntents_List.json
            // this example is just showing the usage of "ReplicationProtectionIntents_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "509099b2-9d2c-4636-b43e-bd5cafb6be69";
            string resourceGroupName = "resourceGroupPS1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ReplicationProtectionIntentResource
            string resourceName = "2007vttp";
            ReplicationProtectionIntentCollection collection = resourceGroupResource.GetReplicationProtectionIntents(resourceName);

            // invoke the operation and iterate over the result
            await foreach (ReplicationProtectionIntentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ReplicationProtectionIntentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets the details of a Replication protection intent item.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheDetailsOfAReplicationProtectionIntentItem()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationProtectionIntents_Get.json
            // this example is just showing the usage of "ReplicationProtectionIntents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "509099b2-9d2c-4636-b43e-bd5cafb6be69";
            string resourceGroupName = "resourceGroupPS1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ReplicationProtectionIntentResource
            string resourceName = "vault1";
            ReplicationProtectionIntentCollection collection = resourceGroupResource.GetReplicationProtectionIntents(resourceName);

            // invoke the operation
            string intentObjectName = "vm1";
            ReplicationProtectionIntentResource result = await collection.GetAsync(intentObjectName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReplicationProtectionIntentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets the details of a Replication protection intent item.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsTheDetailsOfAReplicationProtectionIntentItem()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationProtectionIntents_Get.json
            // this example is just showing the usage of "ReplicationProtectionIntents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "509099b2-9d2c-4636-b43e-bd5cafb6be69";
            string resourceGroupName = "resourceGroupPS1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ReplicationProtectionIntentResource
            string resourceName = "vault1";
            ReplicationProtectionIntentCollection collection = resourceGroupResource.GetReplicationProtectionIntents(resourceName);

            // invoke the operation
            string intentObjectName = "vm1";
            bool result = await collection.ExistsAsync(intentObjectName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets the details of a Replication protection intent item.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsTheDetailsOfAReplicationProtectionIntentItem()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationProtectionIntents_Get.json
            // this example is just showing the usage of "ReplicationProtectionIntents_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "509099b2-9d2c-4636-b43e-bd5cafb6be69";
            string resourceGroupName = "resourceGroupPS1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ReplicationProtectionIntentResource
            string resourceName = "vault1";
            ReplicationProtectionIntentCollection collection = resourceGroupResource.GetReplicationProtectionIntents(resourceName);

            // invoke the operation
            string intentObjectName = "vm1";
            NullableResponse<ReplicationProtectionIntentResource> response = await collection.GetIfExistsAsync(intentObjectName);
            ReplicationProtectionIntentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ReplicationProtectionIntentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create protection intent Resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateProtectionIntentResource()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationProtectionIntents_Create.json
            // this example is just showing the usage of "ReplicationProtectionIntents_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "509099b2-9d2c-4636-b43e-bd5cafb6be69";
            string resourceGroupName = "resourceGroupPS1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ReplicationProtectionIntentResource
            string resourceName = "vault1";
            ReplicationProtectionIntentCollection collection = resourceGroupResource.GetReplicationProtectionIntents(resourceName);

            // invoke the operation
            string intentObjectName = "vm1";
            ReplicationProtectionIntentCreateOrUpdateContent content = new ReplicationProtectionIntentCreateOrUpdateContent()
            {
                SiteRecoveryCreateProtectionIntentProviderSpecificDetails = new A2ACreateProtectionIntentContent(new ResourceIdentifier("/subscriptions/509099b2-9d2c-4636-b43e-bd5cafb6be69/resourceGroups/removeOne/providers/Microsoft.Compute/virtualMachines/vmPpgAv5"), new AzureLocation("eastUs2"), new AzureLocation("westus2"), "ed5bcdf6-d61e-47bd-8ea9-f2bd379a2640", A2ARecoveryAvailabilityType.Single, new ResourceIdentifier("/subscriptions/509099b2-9d2c-4636-b43e-bd5cafb6be69/resourceGroups/removeOne-asr")),
            };
            ArmOperation<ReplicationProtectionIntentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, intentObjectName, content);
            ReplicationProtectionIntentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ReplicationProtectionIntentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
