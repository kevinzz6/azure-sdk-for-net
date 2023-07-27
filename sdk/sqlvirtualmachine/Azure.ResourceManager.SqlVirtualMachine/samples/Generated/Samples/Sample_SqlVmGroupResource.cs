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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SqlVirtualMachine;
using Azure.ResourceManager.SqlVirtualMachine.Models;

namespace Azure.ResourceManager.SqlVirtualMachine.Samples
{
    public partial class Sample_SqlVmGroupResource
    {
        // Gets a SQL virtual machine group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsASQLVirtualMachineGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/GetSqlVirtualMachineGroup.json
            // this example is just showing the usage of "SqlVirtualMachineGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlVmGroupResource created on azure
            // for more information of creating SqlVmGroupResource, please refer to the document of SqlVmGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            ResourceIdentifier sqlVmGroupResourceId = SqlVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName);
            SqlVmGroupResource sqlVmGroup = client.GetSqlVmGroupResource(sqlVmGroupResourceId);

            // invoke the operation
            SqlVmGroupResource result = await sqlVmGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes a SQL virtual machine group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesASQLVirtualMachineGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/DeleteSqlVirtualMachineGroup.json
            // this example is just showing the usage of "SqlVirtualMachineGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlVmGroupResource created on azure
            // for more information of creating SqlVmGroupResource, please refer to the document of SqlVmGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            ResourceIdentifier sqlVmGroupResourceId = SqlVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName);
            SqlVmGroupResource sqlVmGroup = client.GetSqlVmGroupResource(sqlVmGroupResourceId);

            // invoke the operation
            await sqlVmGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Updates a SQL virtual machine group tags.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatesASQLVirtualMachineGroupTags()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/UpdateSqlVirtualMachineGroup.json
            // this example is just showing the usage of "SqlVirtualMachineGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlVmGroupResource created on azure
            // for more information of creating SqlVmGroupResource, please refer to the document of SqlVmGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvmgroup";
            ResourceIdentifier sqlVmGroupResourceId = SqlVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName);
            SqlVmGroupResource sqlVmGroup = client.GetSqlVmGroupResource(sqlVmGroupResourceId);

            // invoke the operation
            SqlVmGroupPatch patch = new SqlVmGroupPatch()
            {
                Tags =
{
["mytag"] = "myval",
},
            };
            ArmOperation<SqlVmGroupResource> lro = await sqlVmGroup.UpdateAsync(WaitUntil.Completed, patch);
            SqlVmGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlVmGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets all SQL virtual machine groups in a subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSqlVmGroups_GetsAllSQLVirtualMachineGroupsInASubscription()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/ListSubscriptionSqlVirtualMachineGroup.json
            // this example is just showing the usage of "SqlVirtualMachineGroups_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SqlVmGroupResource item in subscriptionResource.GetSqlVmGroupsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlVmGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets the list of sql virtual machines in a SQL virtual machine group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSqlVmsBySqlVmGroup_GetsTheListOfSqlVirtualMachinesInASQLVirtualMachineGroup()
        {
            // Generated from example definition: specification/sqlvirtualmachine/resource-manager/Microsoft.SqlVirtualMachine/stable/2022-02-01/examples/ListBySqlVirtualMachineGroupSqlVirtualMachine.json
            // this example is just showing the usage of "SqlVirtualMachines_ListBySqlVmGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlVmGroupResource created on azure
            // for more information of creating SqlVmGroupResource, please refer to the document of SqlVmGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "testrg";
            string sqlVmGroupName = "testvm";
            ResourceIdentifier sqlVmGroupResourceId = SqlVmGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sqlVmGroupName);
            SqlVmGroupResource sqlVmGroup = client.GetSqlVmGroupResource(sqlVmGroupResourceId);

            // invoke the operation and iterate over the result
            await foreach (SqlVmResource item in sqlVmGroup.GetSqlVmsBySqlVmGroupAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlVmData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
