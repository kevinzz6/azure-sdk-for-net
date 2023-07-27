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
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SyncGroupResource
    {
        // Get a sync database ID
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSyncDatabaseIdsSyncGroups_GetASyncDatabaseID()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncGroupGetSyncDatabaseId.json
            // this example is just showing the usage of "SyncGroups_ListSyncDatabaseIds" operation, for the dependent resources, they will have to be created separately.

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
            AzureLocation locationName = new AzureLocation("westus");
            await foreach (SubResource item in subscriptionResource.GetSyncDatabaseIdsSyncGroupsAsync(locationName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Refresh a hub database schema.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RefreshHubSchema_RefreshAHubDatabaseSchema()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncGroupRefreshHubSchema.json
            // this example is just showing the usage of "SyncGroups_RefreshHubSchema" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncGroupResource created on azure
            // for more information of creating SyncGroupResource, please refer to the document of SyncGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            ResourceIdentifier syncGroupResourceId = SyncGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName);
            SyncGroupResource syncGroup = client.GetSyncGroupResource(syncGroupResourceId);

            // invoke the operation
            await syncGroup.RefreshHubSchemaAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a hub database schema.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetHubSchemas_GetAHubDatabaseSchema()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncGroupGetHubSchema.json
            // this example is just showing the usage of "SyncGroups_ListHubSchemas" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncGroupResource created on azure
            // for more information of creating SyncGroupResource, please refer to the document of SyncGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            ResourceIdentifier syncGroupResourceId = SyncGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName);
            SyncGroupResource syncGroup = client.GetSyncGroupResource(syncGroupResourceId);

            // invoke the operation and iterate over the result
            await foreach (SyncFullSchemaProperties item in syncGroup.GetHubSchemasAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get sync group logs
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetLogs_GetSyncGroupLogs()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncGroupGetLog.json
            // this example is just showing the usage of "SyncGroups_ListLogs" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncGroupResource created on azure
            // for more information of creating SyncGroupResource, please refer to the document of SyncGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            ResourceIdentifier syncGroupResourceId = SyncGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName);
            SyncGroupResource syncGroup = client.GetSyncGroupResource(syncGroupResourceId);

            // invoke the operation and iterate over the result
            string startTime = "2017-01-01T00:00:00";
            string endTime = "2017-12-31T00:00:00";
            SyncGroupLogType type = SyncGroupLogType.All;
            await foreach (SyncGroupLogProperties item in syncGroup.GetLogsAsync(startTime, endTime, type))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Cancel a sync group synchronization
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CancelSync_CancelASyncGroupSynchronization()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncGroupCancelSync.json
            // this example is just showing the usage of "SyncGroups_CancelSync" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncGroupResource created on azure
            // for more information of creating SyncGroupResource, please refer to the document of SyncGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            ResourceIdentifier syncGroupResourceId = SyncGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName);
            SyncGroupResource syncGroup = client.GetSyncGroupResource(syncGroupResourceId);

            // invoke the operation
            await syncGroup.CancelSyncAsync();

            Console.WriteLine($"Succeeded");
        }

        // Trigger a sync group synchronization.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task TriggerSync_TriggerASyncGroupSynchronization()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncGroupTriggerSync.json
            // this example is just showing the usage of "SyncGroups_TriggerSync" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncGroupResource created on azure
            // for more information of creating SyncGroupResource, please refer to the document of SyncGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            ResourceIdentifier syncGroupResourceId = SyncGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName);
            SyncGroupResource syncGroup = client.GetSyncGroupResource(syncGroupResourceId);

            // invoke the operation
            await syncGroup.TriggerSyncAsync();

            Console.WriteLine($"Succeeded");
        }

        // Get a sync group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetASyncGroup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncGroupGet.json
            // this example is just showing the usage of "SyncGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncGroupResource created on azure
            // for more information of creating SyncGroupResource, please refer to the document of SyncGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            ResourceIdentifier syncGroupResourceId = SyncGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName);
            SyncGroupResource syncGroup = client.GetSyncGroupResource(syncGroupResourceId);

            // invoke the operation
            SyncGroupResource result = await syncGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SyncGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a sync group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteASyncGroup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncGroupDelete.json
            // this example is just showing the usage of "SyncGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncGroupResource created on azure
            // for more information of creating SyncGroupResource, please refer to the document of SyncGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            ResourceIdentifier syncGroupResourceId = SyncGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName);
            SyncGroupResource syncGroup = client.GetSyncGroupResource(syncGroupResourceId);

            // invoke the operation
            await syncGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update a sync group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateASyncGroup()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/SyncGroupPatch.json
            // this example is just showing the usage of "SyncGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SyncGroupResource created on azure
            // for more information of creating SyncGroupResource, please refer to the document of SyncGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "syncgroupcrud-65440";
            string serverName = "syncgroupcrud-8475";
            string databaseName = "syncgroupcrud-4328";
            string syncGroupName = "syncgroupcrud-3187";
            ResourceIdentifier syncGroupResourceId = SyncGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName, syncGroupName);
            SyncGroupResource syncGroup = client.GetSyncGroupResource(syncGroupResourceId);

            // invoke the operation
            SyncGroupData data = new SyncGroupData()
            {
                Interval = -1,
                ConflictResolutionPolicy = SyncConflictResolutionPolicy.HubWin,
                SyncDatabaseId = new ResourceIdentifier("/subscriptions/00000000-1111-2222-3333-444444444444/resourceGroups/syncgroupcrud-3521/providers/Microsoft.Sql/servers/syncgroupcrud-8475/databases/syncgroupcrud-4328"),
                HubDatabaseUserName = "hubUser",
                HubDatabasePassword = "hubPassword",
                UsePrivateLinkConnection = true,
            };
            ArmOperation<SyncGroupResource> lro = await syncGroup.UpdateAsync(WaitUntil.Completed, data);
            SyncGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SyncGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
