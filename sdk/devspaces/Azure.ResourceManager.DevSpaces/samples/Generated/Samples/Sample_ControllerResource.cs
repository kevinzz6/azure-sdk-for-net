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
using Azure.ResourceManager.DevSpaces;
using Azure.ResourceManager.DevSpaces.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevSpaces.Samples
{
    public partial class Sample_ControllerResource
    {
        // ControllersGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ControllersGet()
        {
            // Generated from example definition: specification/devspaces/resource-manager/Microsoft.DevSpaces/stable/2019-04-01/examples/ControllersGet_example.json
            // this example is just showing the usage of "Controllers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ControllerResource created on azure
            // for more information of creating ControllerResource, please refer to the document of ControllerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string name = "myControllerResource";
            ResourceIdentifier controllerResourceId = ControllerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ControllerResource controller = client.GetControllerResource(controllerResourceId);

            // invoke the operation
            ControllerResource result = await controller.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ControllerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ControllersDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ControllersDelete()
        {
            // Generated from example definition: specification/devspaces/resource-manager/Microsoft.DevSpaces/stable/2019-04-01/examples/ControllersDelete_example.json
            // this example is just showing the usage of "Controllers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ControllerResource created on azure
            // for more information of creating ControllerResource, please refer to the document of ControllerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string name = "myControllerResource";
            ResourceIdentifier controllerResourceId = ControllerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ControllerResource controller = client.GetControllerResource(controllerResourceId);

            // invoke the operation
            await controller.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ControllersUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ControllersUpdate()
        {
            // Generated from example definition: specification/devspaces/resource-manager/Microsoft.DevSpaces/stable/2019-04-01/examples/ControllersUpdate_example.json
            // this example is just showing the usage of "Controllers_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ControllerResource created on azure
            // for more information of creating ControllerResource, please refer to the document of ControllerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string name = "myControllerResource";
            ResourceIdentifier controllerResourceId = ControllerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ControllerResource controller = client.GetControllerResource(controllerResourceId);

            // invoke the operation
            ControllerPatch patch = new ControllerPatch()
            {
                Tags =
{
["key"] = "value",
},
                TargetContainerHostCredentialsBase64 = "QmFzZTY0IEVuY29kZWQgVmFsdWUK",
            };
            ControllerResource result = await controller.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ControllerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ControllersList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetControllers_ControllersList()
        {
            // Generated from example definition: specification/devspaces/resource-manager/Microsoft.DevSpaces/stable/2019-04-01/examples/ControllersList_example.json
            // this example is just showing the usage of "Controllers_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ControllerResource item in subscriptionResource.GetControllersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ControllerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ControllersListConnectionDetails
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetConnectionDetails_ControllersListConnectionDetails()
        {
            // Generated from example definition: specification/devspaces/resource-manager/Microsoft.DevSpaces/stable/2019-04-01/examples/ControllersListConnectionDetails_example.json
            // this example is just showing the usage of "Controllers_ListConnectionDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ControllerResource created on azure
            // for more information of creating ControllerResource, please refer to the document of ControllerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string name = "myControllerResource";
            ResourceIdentifier controllerResourceId = ControllerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ControllerResource controller = client.GetControllerResource(controllerResourceId);

            // invoke the operation
            ListConnectionDetailsContent content = new ListConnectionDetailsContent("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myResourceGroup/providers/Microsoft.ContainerService/managedClusters/myCluster");
            ControllerConnectionDetailsList result = await controller.GetConnectionDetailsAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
