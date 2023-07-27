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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VpnGatewayResource
    {
        // VpnGatewayGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VpnGatewayGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VpnGatewayGet.json
            // this example is just showing the usage of "VpnGateways_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // invoke the operation
            VpnGatewayResource result = await vpnGateway.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VpnGatewayUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VpnGatewayUpdate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VpnGatewayUpdateTags.json
            // this example is just showing the usage of "VpnGateways_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // invoke the operation
            NetworkTagsObject vpnGatewayParameters = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<VpnGatewayResource> lro = await vpnGateway.UpdateAsync(WaitUntil.Completed, vpnGatewayParameters);
            VpnGatewayResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VpnGatewayDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VpnGatewayDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VpnGatewayDelete.json
            // this example is just showing the usage of "VpnGateways_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // invoke the operation
            await vpnGateway.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ResetVpnGateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Reset_ResetVpnGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VpnGatewayReset.json
            // this example is just showing the usage of "VpnGateways_Reset" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "vpngw";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // invoke the operation
            ArmOperation<VpnGatewayResource> lro = await vpnGateway.ResetAsync(WaitUntil.Completed);
            VpnGatewayResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnGatewayData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Start packet capture on vpn gateway with filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task StartPacketCapture_StartPacketCaptureOnVpnGatewayWithFilter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VpnGatewayStartPacketCaptureFilterData.json
            // this example is just showing the usage of "VpnGateways_StartPacketCapture" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "vpngw";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // invoke the operation
            VpnGatewayPacketCaptureStartContent content = new VpnGatewayPacketCaptureStartContent()
            {
                FilterData = "{'TracingFlags': 11,'MaxPacketBufferSize': 120,'MaxFileSize': 200,'Filters': [{'SourceSubnets': ['20.1.1.0/24'],'DestinationSubnets': ['10.1.1.0/24'],'SourcePort': [500],'DestinationPort': [4500],'Protocol': 6,'TcpFlags': 16,'CaptureSingleDirectionTrafficOnly': true}]}",
            };
            ArmOperation<string> lro = await vpnGateway.StartPacketCaptureAsync(WaitUntil.Completed, content: content);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Start packet capture on vpn gateway without filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task StartPacketCapture_StartPacketCaptureOnVpnGatewayWithoutFilter()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VpnGatewayStartPacketCapture.json
            // this example is just showing the usage of "VpnGateways_StartPacketCapture" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "vpngw";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // invoke the operation
            ArmOperation<string> lro = await vpnGateway.StartPacketCaptureAsync(WaitUntil.Completed);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Stop packet capture on vpn gateway
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task StopPacketCapture_StopPacketCaptureOnVpnGateway()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VpnGatewayStopPacketCapture.json
            // this example is just showing the usage of "VpnGateways_StopPacketCapture" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "vpngw";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // invoke the operation
            VpnGatewayPacketCaptureStopContent content = new VpnGatewayPacketCaptureStopContent()
            {
                SasUri = new Uri("https://teststorage.blob.core.windows.net/?sv=2018-03-28&ss=bfqt&srt=sco&sp=rwdlacup&se=2019-09-13T07:44:05Z&st=2019-09-06T23:44:05Z&spr=https&sig=V1h9D1riltvZMI69d6ihENnFo%2FrCvTqGgjO2lf%2FVBhE%3D"),
            };
            ArmOperation<string> lro = await vpnGateway.StopPacketCaptureAsync(WaitUntil.Completed, content: content);
            string result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // VpnGatewayListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVpnGateways_VpnGatewayListBySubscription()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-02-01/examples/VpnGatewayList.json
            // this example is just showing the usage of "VpnGateways_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (VpnGatewayResource item in subscriptionResource.GetVpnGatewaysAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VpnGatewayData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
