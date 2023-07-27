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
using Azure.ResourceManager.Synapse;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseDataConnectionResource
    {
        // KustoPoolDataConnectionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KustoPoolDataConnectionsGet()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDataConnectionsGet.json
            // this example is just showing the usage of "KustoPoolDataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataConnectionResource created on azure
            // for more information of creating SynapseDataConnectionResource, please refer to the document of SynapseDataConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "KustoDatabase8";
            string dataConnectionName = "DataConnections8";
            ResourceIdentifier synapseDataConnectionResourceId = SynapseDataConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, dataConnectionName);
            SynapseDataConnectionResource synapseDataConnection = client.GetSynapseDataConnectionResource(synapseDataConnectionResourceId);

            // invoke the operation
            SynapseDataConnectionResource result = await synapseDataConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoPoolDataConnectionsUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_KustoPoolDataConnectionsUpdate()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDataConnectionsUpdate.json
            // this example is just showing the usage of "KustoPoolDataConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataConnectionResource created on azure
            // for more information of creating SynapseDataConnectionResource, please refer to the document of SynapseDataConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "KustoDatabase8";
            string dataConnectionName = "DataConnections8";
            ResourceIdentifier synapseDataConnectionResourceId = SynapseDataConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, dataConnectionName);
            SynapseDataConnectionResource synapseDataConnection = client.GetSynapseDataConnectionResource(synapseDataConnectionResourceId);

            // invoke the operation
            SynapseDataConnectionData data = new SynapseEventHubDataConnection()
            {
                EventHubResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.EventHub/namespaces/eventhubTestns1/eventhubs/eventhubTest1"),
                ConsumerGroup = "testConsumerGroup1",
                Location = new AzureLocation("westus"),
            };
            ArmOperation<SynapseDataConnectionResource> lro = await synapseDataConnection.UpdateAsync(WaitUntil.Completed, data);
            SynapseDataConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoPoolDataConnectionsDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_KustoPoolDataConnectionsDelete()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDataConnectionsDelete.json
            // this example is just showing the usage of "KustoPoolDataConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataConnectionResource created on azure
            // for more information of creating SynapseDataConnectionResource, please refer to the document of SynapseDataConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "KustoDatabase8";
            string dataConnectionName = "kustoeventhubconnection1";
            ResourceIdentifier synapseDataConnectionResourceId = SynapseDataConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, dataConnectionName);
            SynapseDataConnectionResource synapseDataConnection = client.GetSynapseDataConnectionResource(synapseDataConnectionResourceId);

            // invoke the operation
            await synapseDataConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
