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
    public partial class Sample_SynapseIntegrationRuntimeCollection
    {
        // Get integration runtime
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetIntegrationRuntime()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/IntegrationRuntimes_Get.json
            // this example is just showing the usage of "IntegrationRuntimes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string workspaceName = "exampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseIntegrationRuntimeResource
            SynapseIntegrationRuntimeCollection collection = synapseWorkspace.GetSynapseIntegrationRuntimes();

            // invoke the operation
            string integrationRuntimeName = "exampleIntegrationRuntime";
            SynapseIntegrationRuntimeResource result = await collection.GetAsync(integrationRuntimeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseIntegrationRuntimeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get integration runtime
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetIntegrationRuntime()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/IntegrationRuntimes_Get.json
            // this example is just showing the usage of "IntegrationRuntimes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string workspaceName = "exampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseIntegrationRuntimeResource
            SynapseIntegrationRuntimeCollection collection = synapseWorkspace.GetSynapseIntegrationRuntimes();

            // invoke the operation
            string integrationRuntimeName = "exampleIntegrationRuntime";
            bool result = await collection.ExistsAsync(integrationRuntimeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create integration runtime
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateIntegrationRuntime()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/IntegrationRuntimes_Create.json
            // this example is just showing the usage of "IntegrationRuntimes_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string workspaceName = "exampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseIntegrationRuntimeResource
            SynapseIntegrationRuntimeCollection collection = synapseWorkspace.GetSynapseIntegrationRuntimes();

            // invoke the operation
            string integrationRuntimeName = "exampleIntegrationRuntime";
            SynapseIntegrationRuntimeData data = new SynapseIntegrationRuntimeData(new SynapseSelfHostedIntegrationRuntime()
            {
                Description = "A selfhosted integration runtime",
            });
            ArmOperation<SynapseIntegrationRuntimeResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, integrationRuntimeName, data);
            SynapseIntegrationRuntimeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseIntegrationRuntimeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List integration runtimes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListIntegrationRuntimes()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/IntegrationRuntimes_ListByWorkspace.json
            // this example is just showing the usage of "IntegrationRuntimes_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string workspaceName = "exampleWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseIntegrationRuntimeResource
            SynapseIntegrationRuntimeCollection collection = synapseWorkspace.GetSynapseIntegrationRuntimes();

            // invoke the operation and iterate over the result
            await foreach (SynapseIntegrationRuntimeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseIntegrationRuntimeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
