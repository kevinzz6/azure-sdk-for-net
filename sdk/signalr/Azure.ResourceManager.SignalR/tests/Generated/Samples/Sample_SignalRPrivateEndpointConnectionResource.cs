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
using Azure.ResourceManager.SignalR;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR.Samples
{
    public partial class Sample_SignalRPrivateEndpointConnectionResource
    {
        // SignalRPrivateEndpointConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SignalRPrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/signalr/resource-manager/Microsoft.SignalRService/stable/2022-02-01/examples/SignalRPrivateEndpointConnections_Get.json
            // this example is just showing the usage of "SignalRPrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SignalRPrivateEndpointConnectionResource created on azure
            // for more information of creating SignalRPrivateEndpointConnectionResource, please refer to the document of SignalRPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "mySignalRService";
            string privateEndpointConnectionName = "mysignalrservice.1fa229cd-bf3f-47f0-8c49-afb36723997e";
            ResourceIdentifier signalRPrivateEndpointConnectionResourceId = SignalRPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, privateEndpointConnectionName);
            SignalRPrivateEndpointConnectionResource signalRPrivateEndpointConnection = client.GetSignalRPrivateEndpointConnectionResource(signalRPrivateEndpointConnectionResourceId);

            // invoke the operation
            SignalRPrivateEndpointConnectionResource result = await signalRPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SignalRPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SignalRPrivateEndpointConnections_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SignalRPrivateEndpointConnectionsUpdate()
        {
            // Generated from example definition: specification/signalr/resource-manager/Microsoft.SignalRService/stable/2022-02-01/examples/SignalRPrivateEndpointConnections_Update.json
            // this example is just showing the usage of "SignalRPrivateEndpointConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SignalRPrivateEndpointConnectionResource created on azure
            // for more information of creating SignalRPrivateEndpointConnectionResource, please refer to the document of SignalRPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "mySignalRService";
            string privateEndpointConnectionName = "mysignalrservice.1fa229cd-bf3f-47f0-8c49-afb36723997e";
            ResourceIdentifier signalRPrivateEndpointConnectionResourceId = SignalRPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, privateEndpointConnectionName);
            SignalRPrivateEndpointConnectionResource signalRPrivateEndpointConnection = client.GetSignalRPrivateEndpointConnectionResource(signalRPrivateEndpointConnectionResourceId);

            // invoke the operation
            SignalRPrivateEndpointConnectionData data = new SignalRPrivateEndpointConnectionData()
            {
                PrivateEndpointId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/Microsoft.Network/privateEndpoints/myPrivateEndpoint"),
                ConnectionState = new SignalRPrivateLinkServiceConnectionState()
                {
                    Status = PrivateLinkServiceConnectionStatus.Approved,
                    ActionsRequired = "None",
                },
            };
            ArmOperation<SignalRPrivateEndpointConnectionResource> lro = await signalRPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            SignalRPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SignalRPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SignalRPrivateEndpointConnections_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SignalRPrivateEndpointConnectionsDelete()
        {
            // Generated from example definition: specification/signalr/resource-manager/Microsoft.SignalRService/stable/2022-02-01/examples/SignalRPrivateEndpointConnections_Delete.json
            // this example is just showing the usage of "SignalRPrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SignalRPrivateEndpointConnectionResource created on azure
            // for more information of creating SignalRPrivateEndpointConnectionResource, please refer to the document of SignalRPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "mySignalRService";
            string privateEndpointConnectionName = "mysignalrservice.1fa229cd-bf3f-47f0-8c49-afb36723997e";
            ResourceIdentifier signalRPrivateEndpointConnectionResourceId = SignalRPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, privateEndpointConnectionName);
            SignalRPrivateEndpointConnectionResource signalRPrivateEndpointConnection = client.GetSignalRPrivateEndpointConnectionResource(signalRPrivateEndpointConnectionResourceId);

            // invoke the operation
            await signalRPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
