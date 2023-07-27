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
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_PacketCaptureResource
    {
        // Create packet capture
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatePacketCapture()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/NetworkWatcherPacketCaptureCreate.json
            // this example is just showing the usage of "PacketCaptures_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCaptureResource created on azure
            // for more information of creating PacketCaptureResource, please refer to the document of PacketCaptureResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string packetCaptureName = "pc1";
            ResourceIdentifier packetCaptureResourceId = PacketCaptureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            PacketCaptureResource packetCapture = client.GetPacketCaptureResource(packetCaptureResourceId);

            // invoke the operation
            PacketCaptureCreateOrUpdateContent content = new PacketCaptureCreateOrUpdateContent("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Compute/virtualMachines/vm1", new PacketCaptureStorageLocation()
            {
                StorageId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg2/providers/Microsoft.Storage/storageAccounts/pcstore"),
                StoragePath = "https://mytestaccountname.blob.core.windows.net/capture/pc1.cap",
                FilePath = "D:\\capture\\pc1.cap",
            })
            {
                BytesToCapturePerPacket = 10000,
                TotalBytesPerSession = 100000,
                TimeLimitInSeconds = 100,
                Filters =
{
new PacketCaptureFilter()
{
Protocol = PcProtocol.Tcp,
LocalIPAddress = "10.0.0.4",
LocalPort = "80",
}
},
            };
            ArmOperation<PacketCaptureResource> lro = await packetCapture.UpdateAsync(WaitUntil.Completed, content);
            PacketCaptureResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PacketCaptureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get packet capture
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPacketCapture()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/NetworkWatcherPacketCaptureGet.json
            // this example is just showing the usage of "PacketCaptures_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCaptureResource created on azure
            // for more information of creating PacketCaptureResource, please refer to the document of PacketCaptureResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string packetCaptureName = "pc1";
            ResourceIdentifier packetCaptureResourceId = PacketCaptureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            PacketCaptureResource packetCapture = client.GetPacketCaptureResource(packetCaptureResourceId);

            // invoke the operation
            PacketCaptureResource result = await packetCapture.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PacketCaptureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete packet capture
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletePacketCapture()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/NetworkWatcherPacketCaptureDelete.json
            // this example is just showing the usage of "PacketCaptures_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCaptureResource created on azure
            // for more information of creating PacketCaptureResource, please refer to the document of PacketCaptureResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string packetCaptureName = "pc1";
            ResourceIdentifier packetCaptureResourceId = PacketCaptureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            PacketCaptureResource packetCapture = client.GetPacketCaptureResource(packetCaptureResourceId);

            // invoke the operation
            await packetCapture.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Stop packet capture
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Stop_StopPacketCapture()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/NetworkWatcherPacketCaptureStop.json
            // this example is just showing the usage of "PacketCaptures_Stop" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCaptureResource created on azure
            // for more information of creating PacketCaptureResource, please refer to the document of PacketCaptureResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string packetCaptureName = "pc1";
            ResourceIdentifier packetCaptureResourceId = PacketCaptureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            PacketCaptureResource packetCapture = client.GetPacketCaptureResource(packetCaptureResourceId);

            // invoke the operation
            await packetCapture.StopAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Query packet capture status
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetStatus_QueryPacketCaptureStatus()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/NetworkWatcherPacketCaptureQueryStatus.json
            // this example is just showing the usage of "PacketCaptures_GetStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PacketCaptureResource created on azure
            // for more information of creating PacketCaptureResource, please refer to the document of PacketCaptureResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkWatcherName = "nw1";
            string packetCaptureName = "pc1";
            ResourceIdentifier packetCaptureResourceId = PacketCaptureResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkWatcherName, packetCaptureName);
            PacketCaptureResource packetCapture = client.GetPacketCaptureResource(packetCaptureResourceId);

            // invoke the operation
            ArmOperation<PacketCaptureQueryStatusResult> lro = await packetCapture.GetStatusAsync(WaitUntil.Completed);
            PacketCaptureQueryStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
