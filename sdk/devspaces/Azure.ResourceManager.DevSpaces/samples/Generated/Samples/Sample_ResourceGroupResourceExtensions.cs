// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DevSpaces;
using Azure.ResourceManager.DevSpaces.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevSpaces.Samples
{
    public partial class Sample_ResourceGroupResourceExtensions
    {
        // ContainerHostMappingsGetContainerHostMapping
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetContainerHostMappingContainerHostMapping_ContainerHostMappingsGetContainerHostMapping()
        {
            // Generated from example definition: specification/devspaces/resource-manager/Microsoft.DevSpaces/stable/2019-04-01/examples/ContainerHostMappingsGetContainerHostMapping_example.json
            // this example is just showing the usage of "ContainerHostMappings_GetContainerHostMapping" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("eastus");
            ContainerHostMapping containerHostMapping = new ContainerHostMapping()
            {
                ContainerHostResourceId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.ContainerService/managedClusters/myCluster",
            };
            ContainerHostMapping result = await resourceGroupResource.GetContainerHostMappingContainerHostMappingAsync(location, containerHostMapping);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
