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
    public partial class Sample_DataMaskingPolicyResource
    {
        // Create or update data masking policy max
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateDataMaskingPolicyMax()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/stable/2014-04-01/examples/DataMaskingPolicyCreateOrUpdateMax.json
            // this example is just showing the usage of "DataMaskingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMaskingPolicyResource created on azure
            // for more information of creating DataMaskingPolicyResource, please refer to the document of DataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string serverName = "sqlcrudtest-2080";
            string databaseName = "sqlcrudtest-331";
            ResourceIdentifier dataMaskingPolicyResourceId = DataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            DataMaskingPolicyResource dataMaskingPolicy = client.GetDataMaskingPolicyResource(dataMaskingPolicyResourceId);

            // invoke the operation
            DataMaskingPolicyData data = new DataMaskingPolicyData()
            {
                DataMaskingState = DataMaskingState.Enabled,
                ExemptPrincipals = "testuser;",
            };
            ArmOperation<DataMaskingPolicyResource> lro = await dataMaskingPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            DataMaskingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataMaskingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update data masking policy min
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateDataMaskingPolicyMin()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/stable/2014-04-01/examples/DataMaskingPolicyCreateOrUpdateMin.json
            // this example is just showing the usage of "DataMaskingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMaskingPolicyResource created on azure
            // for more information of creating DataMaskingPolicyResource, please refer to the document of DataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string serverName = "sqlcrudtest-2080";
            string databaseName = "sqlcrudtest-331";
            ResourceIdentifier dataMaskingPolicyResourceId = DataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            DataMaskingPolicyResource dataMaskingPolicy = client.GetDataMaskingPolicyResource(dataMaskingPolicyResourceId);

            // invoke the operation
            DataMaskingPolicyData data = new DataMaskingPolicyData()
            {
                DataMaskingState = DataMaskingState.Enabled,
            };
            ArmOperation<DataMaskingPolicyResource> lro = await dataMaskingPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            DataMaskingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataMaskingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get data masking policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDataMaskingPolicy()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/stable/2014-04-01/examples/DataMaskingPolicyGet.json
            // this example is just showing the usage of "DataMaskingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMaskingPolicyResource created on azure
            // for more information of creating DataMaskingPolicyResource, please refer to the document of DataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string serverName = "sqlcrudtest-2080";
            string databaseName = "sqlcrudtest-331";
            ResourceIdentifier dataMaskingPolicyResourceId = DataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            DataMaskingPolicyResource dataMaskingPolicy = client.GetDataMaskingPolicyResource(dataMaskingPolicyResourceId);

            // invoke the operation
            DataMaskingPolicyResource result = await dataMaskingPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataMaskingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create/Update data masking rule for default max
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdateDataMaskingRule_CreateUpdateDataMaskingRuleForDefaultMax()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/stable/2014-04-01/examples/DataMaskingRuleCreateOrUpdateDefaultMax.json
            // this example is just showing the usage of "DataMaskingRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMaskingPolicyResource created on azure
            // for more information of creating DataMaskingPolicyResource, please refer to the document of DataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string serverName = "sqlcrudtest-2080";
            string databaseName = "sqlcrudtest-331";
            ResourceIdentifier dataMaskingPolicyResourceId = DataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            DataMaskingPolicyResource dataMaskingPolicy = client.GetDataMaskingPolicyResource(dataMaskingPolicyResourceId);

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            DataMaskingRule dataMaskingRule = new DataMaskingRule()
            {
                AliasName = "nickname",
                RuleState = DataMaskingRuleState.Enabled,
                SchemaName = "dbo",
                TableName = "Table_1",
                ColumnName = "test1",
                MaskingFunction = DataMaskingFunction.Default,
            };
            DataMaskingRule result = await dataMaskingPolicy.CreateOrUpdateDataMaskingRuleAsync(dataMaskingRuleName, dataMaskingRule);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create/Update data masking rule for default min
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdateDataMaskingRule_CreateUpdateDataMaskingRuleForDefaultMin()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/stable/2014-04-01/examples/DataMaskingRuleCreateOrUpdateDefaultMin.json
            // this example is just showing the usage of "DataMaskingRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMaskingPolicyResource created on azure
            // for more information of creating DataMaskingPolicyResource, please refer to the document of DataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string serverName = "sqlcrudtest-2080";
            string databaseName = "sqlcrudtest-331";
            ResourceIdentifier dataMaskingPolicyResourceId = DataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            DataMaskingPolicyResource dataMaskingPolicy = client.GetDataMaskingPolicyResource(dataMaskingPolicyResourceId);

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            DataMaskingRule dataMaskingRule = new DataMaskingRule()
            {
                SchemaName = "dbo",
                TableName = "Table_1",
                ColumnName = "test1",
                MaskingFunction = DataMaskingFunction.Default,
            };
            DataMaskingRule result = await dataMaskingPolicy.CreateOrUpdateDataMaskingRuleAsync(dataMaskingRuleName, dataMaskingRule);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create/Update data masking rule for numbers
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdateDataMaskingRule_CreateUpdateDataMaskingRuleForNumbers()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/stable/2014-04-01/examples/DataMaskingRuleCreateOrUpdateNumber.json
            // this example is just showing the usage of "DataMaskingRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMaskingPolicyResource created on azure
            // for more information of creating DataMaskingPolicyResource, please refer to the document of DataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string serverName = "sqlcrudtest-2080";
            string databaseName = "sqlcrudtest-331";
            ResourceIdentifier dataMaskingPolicyResourceId = DataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            DataMaskingPolicyResource dataMaskingPolicy = client.GetDataMaskingPolicyResource(dataMaskingPolicyResourceId);

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            DataMaskingRule dataMaskingRule = new DataMaskingRule()
            {
                SchemaName = "dbo",
                TableName = "Table_1",
                ColumnName = "test1",
                MaskingFunction = DataMaskingFunction.Number,
                NumberFrom = "0",
                NumberTo = "2",
            };
            DataMaskingRule result = await dataMaskingPolicy.CreateOrUpdateDataMaskingRuleAsync(dataMaskingRuleName, dataMaskingRule);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create/Update data masking rule for text
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdateDataMaskingRule_CreateUpdateDataMaskingRuleForText()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/stable/2014-04-01/examples/DataMaskingRuleCreateOrUpdateText.json
            // this example is just showing the usage of "DataMaskingRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMaskingPolicyResource created on azure
            // for more information of creating DataMaskingPolicyResource, please refer to the document of DataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string serverName = "sqlcrudtest-2080";
            string databaseName = "sqlcrudtest-331";
            ResourceIdentifier dataMaskingPolicyResourceId = DataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            DataMaskingPolicyResource dataMaskingPolicy = client.GetDataMaskingPolicyResource(dataMaskingPolicyResourceId);

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            DataMaskingRule dataMaskingRule = new DataMaskingRule()
            {
                SchemaName = "dbo",
                TableName = "Table_1",
                ColumnName = "test1",
                MaskingFunction = DataMaskingFunction.Text,
                PrefixSize = "1",
                SuffixSize = "0",
                ReplacementString = "asdf",
            };
            DataMaskingRule result = await dataMaskingPolicy.CreateOrUpdateDataMaskingRuleAsync(dataMaskingRuleName, dataMaskingRule);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List data masking rules
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDataMaskingRules_ListDataMaskingRules()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/stable/2014-04-01/examples/DataMaskingRuleList.json
            // this example is just showing the usage of "DataMaskingRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataMaskingPolicyResource created on azure
            // for more information of creating DataMaskingPolicyResource, please refer to the document of DataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string serverName = "sqlcrudtest-2080";
            string databaseName = "sqlcrudtest-331";
            ResourceIdentifier dataMaskingPolicyResourceId = DataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            DataMaskingPolicyResource dataMaskingPolicy = client.GetDataMaskingPolicyResource(dataMaskingPolicyResourceId);

            // invoke the operation and iterate over the result
            await foreach (DataMaskingRule item in dataMaskingPolicy.GetDataMaskingRulesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
