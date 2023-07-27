// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_VirtualMachineScaleSetExtensionResource
    {
        // VirtualMachineScaleSetExtension_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VirtualMachineScaleSetExtensionUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-03-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtension_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetExtensionResource, please refer to the document of VirtualMachineScaleSetExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string vmssExtensionName = "aaaa";
            ResourceIdentifier virtualMachineScaleSetExtensionResourceId = VirtualMachineScaleSetExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, vmssExtensionName);
            VirtualMachineScaleSetExtensionResource virtualMachineScaleSetExtension = client.GetVirtualMachineScaleSetExtensionResource(virtualMachineScaleSetExtensionResourceId);

            // invoke the operation
            VirtualMachineScaleSetExtensionPatch patch = new VirtualMachineScaleSetExtensionPatch()
            {
                ForceUpdateTag = "aaaaaaaaa",
                Publisher = "{extension-Publisher}",
                ExtensionType = "{extension-Type}",
                TypeHandlerVersion = "{handler-version}",
                AutoUpgradeMinorVersion = true,
                EnableAutomaticUpgrade = true,
                Settings = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                }),
                ProtectedSettings = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                }),
                ProvisionAfterExtensions =
{
"aa"
},
                SuppressFailures = true,
            };
            ArmOperation<VirtualMachineScaleSetExtensionResource> lro = await virtualMachineScaleSetExtension.UpdateAsync(WaitUntil.Completed, patch);
            VirtualMachineScaleSetExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineScaleSetExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineScaleSetExtension_Update_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VirtualMachineScaleSetExtensionUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-03-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtension_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetExtensionResource, please refer to the document of VirtualMachineScaleSetExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
            string vmssExtensionName = "aa";
            ResourceIdentifier virtualMachineScaleSetExtensionResourceId = VirtualMachineScaleSetExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, vmssExtensionName);
            VirtualMachineScaleSetExtensionResource virtualMachineScaleSetExtension = client.GetVirtualMachineScaleSetExtensionResource(virtualMachineScaleSetExtensionResourceId);

            // invoke the operation
            VirtualMachineScaleSetExtensionPatch patch = new VirtualMachineScaleSetExtensionPatch();
            ArmOperation<VirtualMachineScaleSetExtensionResource> lro = await virtualMachineScaleSetExtension.UpdateAsync(WaitUntil.Completed, patch);
            VirtualMachineScaleSetExtensionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineScaleSetExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineScaleSetExtension_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VirtualMachineScaleSetExtensionDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-03-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtension_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetExtensionResource, please refer to the document of VirtualMachineScaleSetExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string vmssExtensionName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetExtensionResourceId = VirtualMachineScaleSetExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, vmssExtensionName);
            VirtualMachineScaleSetExtensionResource virtualMachineScaleSetExtension = client.GetVirtualMachineScaleSetExtensionResource(virtualMachineScaleSetExtensionResourceId);

            // invoke the operation
            await virtualMachineScaleSetExtension.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VirtualMachineScaleSetExtension_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VirtualMachineScaleSetExtensionDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-03-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtension_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetExtensionResource, please refer to the document of VirtualMachineScaleSetExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaa";
            string vmssExtensionName = "aaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetExtensionResourceId = VirtualMachineScaleSetExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, vmssExtensionName);
            VirtualMachineScaleSetExtensionResource virtualMachineScaleSetExtension = client.GetVirtualMachineScaleSetExtensionResource(virtualMachineScaleSetExtensionResourceId);

            // invoke the operation
            await virtualMachineScaleSetExtension.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VirtualMachineScaleSetExtension_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualMachineScaleSetExtensionGetMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-03-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtension_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetExtensionResource, please refer to the document of VirtualMachineScaleSetExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            string vmssExtensionName = "aaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetExtensionResourceId = VirtualMachineScaleSetExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, vmssExtensionName);
            VirtualMachineScaleSetExtensionResource virtualMachineScaleSetExtension = client.GetVirtualMachineScaleSetExtensionResource(virtualMachineScaleSetExtensionResourceId);

            // invoke the operation
            string expand = "aaaaaaa";
            VirtualMachineScaleSetExtensionResource result = await virtualMachineScaleSetExtension.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineScaleSetExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineScaleSetExtension_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualMachineScaleSetExtensionGetMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-03-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetExtension_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetExtensions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetExtensionResource created on azure
            // for more information of creating VirtualMachineScaleSetExtensionResource, please refer to the document of VirtualMachineScaleSetExtensionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "a";
            string vmssExtensionName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetExtensionResourceId = VirtualMachineScaleSetExtensionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, vmssExtensionName);
            VirtualMachineScaleSetExtensionResource virtualMachineScaleSetExtension = client.GetVirtualMachineScaleSetExtensionResource(virtualMachineScaleSetExtensionResourceId);

            // invoke the operation
            VirtualMachineScaleSetExtensionResource result = await virtualMachineScaleSetExtension.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineScaleSetExtensionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
