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
using Azure.ResourceManager.Avs;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkDhcpResource
    {
        // WorkloadNetworks_GetDhcp
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkloadNetworksGetDhcp()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/WorkloadNetworks_GetDhcpConfigurations.json
            // this example is just showing the usage of "WorkloadNetworks_GetDhcp" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkDhcpResource created on azure
            // for more information of creating WorkloadNetworkDhcpResource, please refer to the document of WorkloadNetworkDhcpResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string dhcpId = "dhcp1";
            ResourceIdentifier workloadNetworkDhcpResourceId = WorkloadNetworkDhcpResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, dhcpId);
            WorkloadNetworkDhcpResource workloadNetworkDhcp = client.GetWorkloadNetworkDhcpResource(workloadNetworkDhcpResourceId);

            // invoke the operation
            WorkloadNetworkDhcpResource result = await workloadNetworkDhcp.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkDhcpData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkloadNetworks_UpdateDhcp
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_WorkloadNetworksUpdateDhcp()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/WorkloadNetworks_UpdateDhcpConfigurations.json
            // this example is just showing the usage of "WorkloadNetworks_UpdateDhcp" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkDhcpResource created on azure
            // for more information of creating WorkloadNetworkDhcpResource, please refer to the document of WorkloadNetworkDhcpResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string dhcpId = "dhcp1";
            ResourceIdentifier workloadNetworkDhcpResourceId = WorkloadNetworkDhcpResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, dhcpId);
            WorkloadNetworkDhcpResource workloadNetworkDhcp = client.GetWorkloadNetworkDhcpResource(workloadNetworkDhcpResourceId);

            // invoke the operation
            WorkloadNetworkDhcpData data = new WorkloadNetworkDhcpData()
            {
                Properties = new WorkloadNetworkDhcpServer()
                {
                    ServerAddress = "40.1.5.1/24",
                    LeaseTime = 86400,
                    Revision = 1,
                },
            };
            ArmOperation<WorkloadNetworkDhcpResource> lro = await workloadNetworkDhcp.UpdateAsync(WaitUntil.Completed, data);
            WorkloadNetworkDhcpResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkDhcpData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkloadNetworks_DeleteDhcp
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_WorkloadNetworksDeleteDhcp()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/WorkloadNetworks_DeleteDhcpConfigurations.json
            // this example is just showing the usage of "WorkloadNetworks_DeleteDhcp" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkDhcpResource created on azure
            // for more information of creating WorkloadNetworkDhcpResource, please refer to the document of WorkloadNetworkDhcpResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            string dhcpId = "dhcp1";
            ResourceIdentifier workloadNetworkDhcpResourceId = WorkloadNetworkDhcpResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName, dhcpId);
            WorkloadNetworkDhcpResource workloadNetworkDhcp = client.GetWorkloadNetworkDhcpResource(workloadNetworkDhcpResourceId);

            // invoke the operation
            await workloadNetworkDhcp.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
