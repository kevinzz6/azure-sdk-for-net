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
    public partial class Sample_SqlServerJobExecutionStepCollection
    {
        // List job step executions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListJobStepExecutions()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/ListJobExecutionSteps.json
            // this example is just showing the usage of "JobStepExecutions_ListByJobExecution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobExecutionResource created on azure
            // for more information of creating SqlServerJobExecutionResource, please refer to the document of SqlServerJobExecutionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            Guid jobExecutionId = Guid.Parse("5A86BF65-43AC-F258-2524-9E92992F97CA");
            ResourceIdentifier sqlServerJobExecutionResourceId = SqlServerJobExecutionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId);
            SqlServerJobExecutionResource sqlServerJobExecution = client.GetSqlServerJobExecutionResource(sqlServerJobExecutionResourceId);

            // get the collection of this SqlServerJobExecutionStepResource
            SqlServerJobExecutionStepCollection collection = sqlServerJobExecution.GetSqlServerJobExecutionSteps();

            // invoke the operation and iterate over the result
            SqlServerJobExecutionStepCollectionGetAllOptions options = new SqlServerJobExecutionStepCollectionGetAllOptions() { };
            await foreach (SqlServerJobExecutionStepResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SqlServerJobExecutionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a job step execution
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAJobStepExecution()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/GetJobExecutionStep.json
            // this example is just showing the usage of "JobStepExecutions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobExecutionResource created on azure
            // for more information of creating SqlServerJobExecutionResource, please refer to the document of SqlServerJobExecutionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            Guid jobExecutionId = Guid.Parse("5A86BF65-43AC-F258-2524-9E92992F97CA");
            ResourceIdentifier sqlServerJobExecutionResourceId = SqlServerJobExecutionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId);
            SqlServerJobExecutionResource sqlServerJobExecution = client.GetSqlServerJobExecutionResource(sqlServerJobExecutionResourceId);

            // get the collection of this SqlServerJobExecutionStepResource
            SqlServerJobExecutionStepCollection collection = sqlServerJobExecution.GetSqlServerJobExecutionSteps();

            // invoke the operation
            string stepName = "step1";
            SqlServerJobExecutionStepResource result = await collection.GetAsync(stepName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SqlServerJobExecutionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a job step execution
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAJobStepExecution()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2020-11-01-preview/examples/GetJobExecutionStep.json
            // this example is just showing the usage of "JobStepExecutions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlServerJobExecutionResource created on azure
            // for more information of creating SqlServerJobExecutionResource, please refer to the document of SqlServerJobExecutionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "group1";
            string serverName = "server1";
            string jobAgentName = "agent1";
            string jobName = "job1";
            Guid jobExecutionId = Guid.Parse("5A86BF65-43AC-F258-2524-9E92992F97CA");
            ResourceIdentifier sqlServerJobExecutionResourceId = SqlServerJobExecutionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, jobAgentName, jobName, jobExecutionId);
            SqlServerJobExecutionResource sqlServerJobExecution = client.GetSqlServerJobExecutionResource(sqlServerJobExecutionResourceId);

            // get the collection of this SqlServerJobExecutionStepResource
            SqlServerJobExecutionStepCollection collection = sqlServerJobExecution.GetSqlServerJobExecutionSteps();

            // invoke the operation
            string stepName = "step1";
            bool result = await collection.ExistsAsync(stepName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
