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
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ManagedBackupShortTermRetentionPolicyResource
    {
        // Get the short term retention policy for the database.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTheShortTermRetentionPolicyForTheDatabase()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/GetManagedShortTermRetentionPolicy.json
            // this example is just showing the usage of "ManagedBackupShortTermRetentionPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedBackupShortTermRetentionPolicyResource created on azure
            // for more information of creating ManagedBackupShortTermRetentionPolicyResource, please refer to the document of ManagedBackupShortTermRetentionPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string managedInstanceName = "testsvr";
            string databaseName = "testdb";
            ManagedShortTermRetentionPolicyName policyName = ManagedShortTermRetentionPolicyName.Default;
            ResourceIdentifier managedBackupShortTermRetentionPolicyResourceId = ManagedBackupShortTermRetentionPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, databaseName, policyName);
            ManagedBackupShortTermRetentionPolicyResource managedBackupShortTermRetentionPolicy = client.GetManagedBackupShortTermRetentionPolicyResource(managedBackupShortTermRetentionPolicyResourceId);

            // invoke the operation
            ManagedBackupShortTermRetentionPolicyResource result = await managedBackupShortTermRetentionPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedBackupShortTermRetentionPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update the short term retention policy for the database.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateTheShortTermRetentionPolicyForTheDatabase()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/UpdateManagedShortTermRetentionPolicy.json
            // this example is just showing the usage of "ManagedBackupShortTermRetentionPolicies_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedBackupShortTermRetentionPolicyResource created on azure
            // for more information of creating ManagedBackupShortTermRetentionPolicyResource, please refer to the document of ManagedBackupShortTermRetentionPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "resourceGroup";
            string managedInstanceName = "testsvr";
            string databaseName = "testdb";
            ManagedShortTermRetentionPolicyName policyName = ManagedShortTermRetentionPolicyName.Default;
            ResourceIdentifier managedBackupShortTermRetentionPolicyResourceId = ManagedBackupShortTermRetentionPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, databaseName, policyName);
            ManagedBackupShortTermRetentionPolicyResource managedBackupShortTermRetentionPolicy = client.GetManagedBackupShortTermRetentionPolicyResource(managedBackupShortTermRetentionPolicyResourceId);

            // invoke the operation
            ManagedBackupShortTermRetentionPolicyData data = new ManagedBackupShortTermRetentionPolicyData()
            {
                RetentionDays = 14,
            };
            ArmOperation<ManagedBackupShortTermRetentionPolicyResource> lro = await managedBackupShortTermRetentionPolicy.UpdateAsync(WaitUntil.Completed, data);
            ManagedBackupShortTermRetentionPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedBackupShortTermRetentionPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
