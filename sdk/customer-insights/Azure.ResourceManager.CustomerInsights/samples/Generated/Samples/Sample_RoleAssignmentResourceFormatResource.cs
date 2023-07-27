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
using Azure.ResourceManager.CustomerInsights;
using Azure.ResourceManager.CustomerInsights.Models;

namespace Azure.ResourceManager.CustomerInsights.Samples
{
    public partial class Sample_RoleAssignmentResourceFormatResource
    {
        // RoleAssignments_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RoleAssignmentsCreateOrUpdate()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RoleAssignmentsCreateOrUpdate.json
            // this example is just showing the usage of "RoleAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RoleAssignmentResourceFormatResource created on azure
            // for more information of creating RoleAssignmentResourceFormatResource, please refer to the document of RoleAssignmentResourceFormatResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string assignmentName = "assignmentName8976";
            ResourceIdentifier roleAssignmentResourceFormatResourceId = RoleAssignmentResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, assignmentName);
            RoleAssignmentResourceFormatResource roleAssignmentResourceFormat = client.GetRoleAssignmentResourceFormatResource(roleAssignmentResourceFormatResourceId);

            // invoke the operation
            RoleAssignmentResourceFormatData data = new RoleAssignmentResourceFormatData()
            {
                Role = RoleType.Admin,
                Principals =
{
new AssignmentPrincipal("4c54c38ffa9b416ba5a6d6c8a20cbe7e","User"),new AssignmentPrincipal("93061d15a5054f2b9948ae25724cf9d5","User")
},
            };
            ArmOperation<RoleAssignmentResourceFormatResource> lro = await roleAssignmentResourceFormat.UpdateAsync(WaitUntil.Completed, data);
            RoleAssignmentResourceFormatResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RoleAssignments_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RoleAssignmentsGet()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RoleAssignmentsGet.json
            // this example is just showing the usage of "RoleAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RoleAssignmentResourceFormatResource created on azure
            // for more information of creating RoleAssignmentResourceFormatResource, please refer to the document of RoleAssignmentResourceFormatResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string assignmentName = "assignmentName8976";
            ResourceIdentifier roleAssignmentResourceFormatResourceId = RoleAssignmentResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, assignmentName);
            RoleAssignmentResourceFormatResource roleAssignmentResourceFormat = client.GetRoleAssignmentResourceFormatResource(roleAssignmentResourceFormatResourceId);

            // invoke the operation
            RoleAssignmentResourceFormatResource result = await roleAssignmentResourceFormat.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RoleAssignmentResourceFormatData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RoleAssignments_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RoleAssignmentsDelete()
        {
            // Generated from example definition: specification/customer-insights/resource-manager/Microsoft.CustomerInsights/stable/2017-04-26/examples/RoleAssignmentsDelete.json
            // this example is just showing the usage of "RoleAssignments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RoleAssignmentResourceFormatResource created on azure
            // for more information of creating RoleAssignmentResourceFormatResource, please refer to the document of RoleAssignmentResourceFormatResource
            string subscriptionId = "subid";
            string resourceGroupName = "TestHubRG";
            string hubName = "sdkTestHub";
            string assignmentName = "assignmentName8976";
            ResourceIdentifier roleAssignmentResourceFormatResourceId = RoleAssignmentResourceFormatResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hubName, assignmentName);
            RoleAssignmentResourceFormatResource roleAssignmentResourceFormat = client.GetRoleAssignmentResourceFormatResource(roleAssignmentResourceFormatResourceId);

            // invoke the operation
            await roleAssignmentResourceFormat.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
