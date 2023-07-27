// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_SqlServerAutomaticTuningResource
    {
        // Get a server's automatic tuning settings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAServerSAutomaticTuningSettings()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ServerAutomaticTuningGet.json
            // this example is just showing the usage of "ServerAutomaticTuning_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerAutomaticTuningResource created on azure
            // for more information of creating SqlServerAutomaticTuningResource, please refer to the document of SqlServerAutomaticTuningResource
            string subscriptionId = "c3aa9078-0000-0000-0000-e36f151182d7";
            string resourceGroupName = "default-sql-onebox";
            string serverName = "testsvr11";
            ResourceIdentifier sqlServerAutomaticTuningResourceId = SqlServerAutomaticTuningResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerAutomaticTuningResource sqlServerAutomaticTuning = client.GetSqlServerAutomaticTuningResource(sqlServerAutomaticTuningResourceId);

            // invoke the operation
            SqlServerAutomaticTuningResource result = await sqlServerAutomaticTuning.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerAutomaticTuningData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Updates server automatic tuning settings with all properties
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatesServerAutomaticTuningSettingsWithAllProperties()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ServerAutomaticTuningUpdateMax.json
            // this example is just showing the usage of "ServerAutomaticTuning_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerAutomaticTuningResource created on azure
            // for more information of creating SqlServerAutomaticTuningResource, please refer to the document of SqlServerAutomaticTuningResource
            string subscriptionId = "c3aa9078-0000-0000-0000-e36f151182d7";
            string resourceGroupName = "default-sql-onebox";
            string serverName = "testsvr11";
            ResourceIdentifier sqlServerAutomaticTuningResourceId = SqlServerAutomaticTuningResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerAutomaticTuningResource sqlServerAutomaticTuning = client.GetSqlServerAutomaticTuningResource(sqlServerAutomaticTuningResourceId);

            // invoke the operation
            SqlServerAutomaticTuningData data = new SqlServerAutomaticTuningData()
            {
                DesiredState = AutomaticTuningServerMode.Auto,
                Options =
{
["createIndex"] = new AutomaticTuningServerOptions()
{
DesiredState = AutomaticTuningOptionModeDesired.Off,
},
["dropIndex"] = new AutomaticTuningServerOptions()
{
DesiredState = AutomaticTuningOptionModeDesired.On,
},
["forceLastGoodPlan"] = new AutomaticTuningServerOptions()
{
DesiredState = AutomaticTuningOptionModeDesired.Default,
},
},
            };
            SqlServerAutomaticTuningResource result = await sqlServerAutomaticTuning.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerAutomaticTuningData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Updates server automatic tuning settings with minimal properties
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdatesServerAutomaticTuningSettingsWithMinimalProperties()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ServerAutomaticTuningUpdateMin.json
            // this example is just showing the usage of "ServerAutomaticTuning_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerAutomaticTuningResource created on azure
            // for more information of creating SqlServerAutomaticTuningResource, please refer to the document of SqlServerAutomaticTuningResource
            string subscriptionId = "c3aa9078-0000-0000-0000-e36f151182d7";
            string resourceGroupName = "default-sql-onebox";
            string serverName = "testsvr11";
            ResourceIdentifier sqlServerAutomaticTuningResourceId = SqlServerAutomaticTuningResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            SqlServerAutomaticTuningResource sqlServerAutomaticTuning = client.GetSqlServerAutomaticTuningResource(sqlServerAutomaticTuningResourceId);

            // invoke the operation
            SqlServerAutomaticTuningData data = new SqlServerAutomaticTuningData()
            {
                DesiredState = AutomaticTuningServerMode.Auto,
            };
            SqlServerAutomaticTuningResource result = await sqlServerAutomaticTuning.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerAutomaticTuningData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
