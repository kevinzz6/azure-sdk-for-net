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
using Azure.ResourceManager.DesktopVirtualization;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_VirtualApplicationGroupCollection
    {
        // ApplicationGroup_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApplicationGroupGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2022-09-09/examples/ApplicationGroup_Get.json
            // this example is just showing the usage of "ApplicationGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualApplicationGroupResource
            VirtualApplicationGroupCollection collection = resourceGroupResource.GetVirtualApplicationGroups();

            // invoke the operation
            string applicationGroupName = "applicationGroup1";
            VirtualApplicationGroupResource result = await collection.GetAsync(applicationGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualApplicationGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApplicationGroup_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApplicationGroupGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2022-09-09/examples/ApplicationGroup_Get.json
            // this example is just showing the usage of "ApplicationGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualApplicationGroupResource
            VirtualApplicationGroupCollection collection = resourceGroupResource.GetVirtualApplicationGroups();

            // invoke the operation
            string applicationGroupName = "applicationGroup1";
            bool result = await collection.ExistsAsync(applicationGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApplicationGroup_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApplicationGroupCreate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2022-09-09/examples/ApplicationGroup_Create.json
            // this example is just showing the usage of "ApplicationGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualApplicationGroupResource
            VirtualApplicationGroupCollection collection = resourceGroupResource.GetVirtualApplicationGroups();

            // invoke the operation
            string applicationGroupName = "applicationGroup1";
            VirtualApplicationGroupData data = new VirtualApplicationGroupData(new AzureLocation("centralus"), new ResourceIdentifier("/subscriptions/daefabc0-95b4-48b3-b645-8a753a63c4fa/resourceGroups/resourceGroup1/providers/Microsoft.DesktopVirtualization/hostPools/hostPool1"), VirtualApplicationGroupType.RemoteApp)
            {
                Description = "des1",
                FriendlyName = "friendly",
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<VirtualApplicationGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationGroupName, data);
            VirtualApplicationGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualApplicationGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApplicationGroup_ListByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApplicationGroupListByResourceGroup()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2022-09-09/examples/ApplicationGroup_ListByResourceGroup.json
            // this example is just showing the usage of "ApplicationGroups_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this VirtualApplicationGroupResource
            VirtualApplicationGroupCollection collection = resourceGroupResource.GetVirtualApplicationGroups();

            // invoke the operation and iterate over the result
            string filter = "applicationGroupType eq 'RailApplication'";
            int? pageSize = 10;
            bool? isDescending = true;
            int? initialSkip = 0;
            await foreach (VirtualApplicationGroupResource item in collection.GetAllAsync(filter: filter, pageSize: pageSize, isDescending: isDescending, initialSkip: initialSkip))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualApplicationGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
