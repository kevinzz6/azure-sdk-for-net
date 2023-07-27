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
using Azure.ResourceManager.DataMigration;
using Azure.ResourceManager.DataMigration.Models;

namespace Azure.ResourceManager.DataMigration.Samples
{
    public partial class Sample_ServiceProjectTaskCollection
    {
        // Tasks_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_TasksList()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Tasks_List.json
            // this example is just showing the usage of "Tasks_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string projectName = "DmsSdkProject";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ServiceProjectTaskResource
            ServiceProjectTaskCollection collection = project.GetServiceProjectTasks();

            // invoke the operation and iterate over the result
            await foreach (ServiceProjectTaskResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ProjectTaskData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Tasks_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_TasksCreateOrUpdate()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Tasks_CreateOrUpdate.json
            // this example is just showing the usage of "Tasks_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string projectName = "DmsSdkProject";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ServiceProjectTaskResource
            ServiceProjectTaskCollection collection = project.GetServiceProjectTasks();

            // invoke the operation
            string taskName = "DmsSdkTask";
            ProjectTaskData data = new ProjectTaskData()
            {
                Properties = new ConnectToTargetSqlDBTaskProperties()
                {
                    Input = new ConnectToTargetSqlDBTaskInput(new SqlConnectionInfo("ssma-test-server.database.windows.net")
                    {
                        Authentication = AuthenticationType.SqlAuthentication,
                        EncryptConnection = true,
                        TrustServerCertificate = true,
                        UserName = "testuser",
                        Password = "testpassword",
                    }),
                },
            };
            ArmOperation<ServiceProjectTaskResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, taskName, data);
            ServiceProjectTaskResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProjectTaskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Tasks_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TasksGet()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Tasks_Get.json
            // this example is just showing the usage of "Tasks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string projectName = "DmsSdkProject";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ServiceProjectTaskResource
            ServiceProjectTaskCollection collection = project.GetServiceProjectTasks();

            // invoke the operation
            string taskName = "DmsSdkTask";
            ServiceProjectTaskResource result = await collection.GetAsync(taskName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ProjectTaskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Tasks_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_TasksGet()
        {
            // Generated from example definition: specification/datamigration/resource-manager/Microsoft.DataMigration/preview/2022-03-30-preview/examples/Tasks_Get.json
            // this example is just showing the usage of "Tasks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProjectResource created on azure
            // for more information of creating ProjectResource, please refer to the document of ProjectResource
            string subscriptionId = "fc04246f-04c5-437e-ac5e-206a19e7193f";
            string groupName = "DmsSdkRg";
            string serviceName = "DmsSdkService";
            string projectName = "DmsSdkProject";
            ResourceIdentifier projectResourceId = ProjectResource.CreateResourceIdentifier(subscriptionId, groupName, serviceName, projectName);
            ProjectResource project = client.GetProjectResource(projectResourceId);

            // get the collection of this ServiceProjectTaskResource
            ServiceProjectTaskCollection collection = project.GetServiceProjectTasks();

            // invoke the operation
            string taskName = "DmsSdkTask";
            bool result = await collection.ExistsAsync(taskName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
