// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Grafana;

namespace Azure.ResourceManager.Grafana.Samples
{
    public partial class Sample_GrafanaPrivateLinkResource
    {
        // PrivateLinkResources_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2022-08-01/examples/PrivateLinkResources_Get.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GrafanaPrivateLinkResource created on azure
            // for more information of creating GrafanaPrivateLinkResource, please refer to the document of GrafanaPrivateLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            string privateLinkResourceName = "grafana";
            ResourceIdentifier grafanaPrivateLinkResourceId = GrafanaPrivateLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateLinkResourceName);
            GrafanaPrivateLinkResource grafanaPrivateLinkResource = client.GetGrafanaPrivateLinkResource(grafanaPrivateLinkResourceId);

            // invoke the operation
            GrafanaPrivateLinkResource result = await grafanaPrivateLinkResource.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GrafanaPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
