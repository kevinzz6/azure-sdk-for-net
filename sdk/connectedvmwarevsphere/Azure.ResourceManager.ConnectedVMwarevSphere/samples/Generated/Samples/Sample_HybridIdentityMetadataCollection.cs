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
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Samples
{
    public partial class Sample_HybridIdentityMetadataCollection
    {
        // CreateHybridIdentityMetadata
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateHybridIdentityMetadata()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/preview/2020-10-01-preview/examples/CreateHybridIdentityMetadata.json
            // this example is just showing the usage of "HybridIdentityMetadata_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "ContosoVm";
            ResourceIdentifier virtualMachineResourceId = VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // get the collection of this HybridIdentityMetadataResource
            HybridIdentityMetadataCollection collection = virtualMachine.GetAllHybridIdentityMetadata();

            // invoke the operation
            string metadataName = "default";
            HybridIdentityMetadataData data = new HybridIdentityMetadataData()
            {
                VmId = "f8b82dff-38ef-4220-99ef-d3a3f86ddc6c",
                PublicKey = "8ec7d60c-9700-40b1-8e6e-e5b2f6f477f2",
            };
            ArmOperation<HybridIdentityMetadataResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, metadataName, data);
            HybridIdentityMetadataResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridIdentityMetadataData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetHybridIdentityMetadata
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetHybridIdentityMetadata()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/preview/2020-10-01-preview/examples/GetHybridIdentityMetadata.json
            // this example is just showing the usage of "HybridIdentityMetadata_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "ContosoVm";
            ResourceIdentifier virtualMachineResourceId = VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // get the collection of this HybridIdentityMetadataResource
            HybridIdentityMetadataCollection collection = virtualMachine.GetAllHybridIdentityMetadata();

            // invoke the operation
            string metadataName = "default";
            HybridIdentityMetadataResource result = await collection.GetAsync(metadataName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridIdentityMetadataData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetHybridIdentityMetadata
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetHybridIdentityMetadata()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/preview/2020-10-01-preview/examples/GetHybridIdentityMetadata.json
            // this example is just showing the usage of "HybridIdentityMetadata_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "ContosoVm";
            ResourceIdentifier virtualMachineResourceId = VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // get the collection of this HybridIdentityMetadataResource
            HybridIdentityMetadataCollection collection = virtualMachine.GetAllHybridIdentityMetadata();

            // invoke the operation
            string metadataName = "default";
            bool result = await collection.ExistsAsync(metadataName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // HybridIdentityMetadataListByVm
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_HybridIdentityMetadataListByVm()
        {
            // Generated from example definition: specification/connectedvmware/resource-manager/Microsoft.ConnectedVMwarevSphere/preview/2020-10-01-preview/examples/HybridIdentityMetadata_ListByVm.json
            // this example is just showing the usage of "HybridIdentityMetadata_ListByVm" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "testrg";
            string virtualMachineName = "ContosoVm";
            ResourceIdentifier virtualMachineResourceId = VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // get the collection of this HybridIdentityMetadataResource
            HybridIdentityMetadataCollection collection = virtualMachine.GetAllHybridIdentityMetadata();

            // invoke the operation and iterate over the result
            await foreach (HybridIdentityMetadataResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridIdentityMetadataData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
