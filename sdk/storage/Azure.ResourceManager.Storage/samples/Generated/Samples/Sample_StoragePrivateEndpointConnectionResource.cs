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
using Azure.ResourceManager.Storage;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage.Samples
{
    public partial class Sample_StoragePrivateEndpointConnectionResource
    {
        // StorageAccountGetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StorageAccountGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StoragePrivateEndpointConnectionResource created on azure
            // for more information of creating StoragePrivateEndpointConnectionResource, please refer to the document of StoragePrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier storagePrivateEndpointConnectionResourceId = StoragePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionName);
            StoragePrivateEndpointConnectionResource storagePrivateEndpointConnection = client.GetStoragePrivateEndpointConnectionResource(storagePrivateEndpointConnectionResourceId);

            // invoke the operation
            StoragePrivateEndpointConnectionResource result = await storagePrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StoragePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountPutPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_StorageAccountPutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountPutPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StoragePrivateEndpointConnectionResource created on azure
            // for more information of creating StoragePrivateEndpointConnectionResource, please refer to the document of StoragePrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "sto9699";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier storagePrivateEndpointConnectionResourceId = StoragePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionName);
            StoragePrivateEndpointConnectionResource storagePrivateEndpointConnection = client.GetStoragePrivateEndpointConnectionResource(storagePrivateEndpointConnectionResourceId);

            // invoke the operation
            StoragePrivateEndpointConnectionData data = new StoragePrivateEndpointConnectionData()
            {
                ConnectionState = new StoragePrivateLinkServiceConnectionState()
                {
                    Status = StoragePrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<StoragePrivateEndpointConnectionResource> lro = await storagePrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            StoragePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StoragePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StorageAccountDeletePrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_StorageAccountDeletePrivateEndpointConnection()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2022-09-01/examples/StorageAccountDeletePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StoragePrivateEndpointConnectionResource created on azure
            // for more information of creating StoragePrivateEndpointConnectionResource, please refer to the document of StoragePrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            string privateEndpointConnectionName = "{privateEndpointConnectionName}";
            ResourceIdentifier storagePrivateEndpointConnectionResourceId = StoragePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, privateEndpointConnectionName);
            StoragePrivateEndpointConnectionResource storagePrivateEndpointConnection = client.GetStoragePrivateEndpointConnectionResource(storagePrivateEndpointConnectionResourceId);

            // invoke the operation
            await storagePrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
