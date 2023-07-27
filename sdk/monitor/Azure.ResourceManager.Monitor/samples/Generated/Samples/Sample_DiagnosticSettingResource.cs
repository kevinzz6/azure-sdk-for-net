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
using Azure.ResourceManager.Monitor;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor.Samples
{
    public partial class Sample_DiagnosticSettingResource
    {
        // Gets the diagnostic setting
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheDiagnosticSetting()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/preview/2021-05-01-preview/examples/getDiagnosticSetting.json
            // this example is just showing the usage of "DiagnosticSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiagnosticSettingResource created on azure
            // for more information of creating DiagnosticSettingResource, please refer to the document of DiagnosticSettingResource
            string resourceUri = "subscriptions/1a66ce04-b633-4a0b-b2bc-a912ec8986a6/resourcegroups/viruela1/providers/microsoft.logic/workflows/viruela6";
            string name = "mysetting";
            ResourceIdentifier diagnosticSettingResourceId = DiagnosticSettingResource.CreateResourceIdentifier(resourceUri, name);
            DiagnosticSettingResource diagnosticSetting = client.GetDiagnosticSettingResource(diagnosticSettingResourceId);

            // invoke the operation
            DiagnosticSettingResource result = await diagnosticSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets the diagnostic setting for category
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheDiagnosticSettingForCategory()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/preview/2021-05-01-preview/examples/getDiagnosticSettingCategory.json
            // this example is just showing the usage of "DiagnosticSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiagnosticSettingResource created on azure
            // for more information of creating DiagnosticSettingResource, please refer to the document of DiagnosticSettingResource
            string resourceUri = "subscriptions/1a66ce04-b633-4a0b-b2bc-a912ec8986a6/resourcegroups/viruela1/providers/microsoft.logic/workflows/viruela6";
            string name = "mysetting";
            ResourceIdentifier diagnosticSettingResourceId = DiagnosticSettingResource.CreateResourceIdentifier(resourceUri, name);
            DiagnosticSettingResource diagnosticSetting = client.GetDiagnosticSettingResource(diagnosticSettingResourceId);

            // invoke the operation
            DiagnosticSettingResource result = await diagnosticSetting.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Creates or Updates the diagnostic setting
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatesOrUpdatesTheDiagnosticSetting()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/preview/2021-05-01-preview/examples/createOrUpdateDiagnosticSetting.json
            // this example is just showing the usage of "DiagnosticSettings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiagnosticSettingResource created on azure
            // for more information of creating DiagnosticSettingResource, please refer to the document of DiagnosticSettingResource
            string resourceUri = "subscriptions/1a66ce04-b633-4a0b-b2bc-a912ec8986a6/resourcegroups/viruela1/providers/microsoft.logic/workflows/viruela6";
            string name = "mysetting";
            ResourceIdentifier diagnosticSettingResourceId = DiagnosticSettingResource.CreateResourceIdentifier(resourceUri, name);
            DiagnosticSettingResource diagnosticSetting = client.GetDiagnosticSettingResource(diagnosticSettingResourceId);

            // invoke the operation
            DiagnosticSettingData data = new DiagnosticSettingData()
            {
                StorageAccountId = new ResourceIdentifier("/subscriptions/df602c9c-7aa0-407d-a6fb-eb20c8bd1192/resourceGroups/apptest/providers/Microsoft.Storage/storageAccounts/appteststorage1"),
                EventHubAuthorizationRuleId = new ResourceIdentifier("/subscriptions/1a66ce04-b633-4a0b-b2bc-a912ec8986a6/resourceGroups/montest/providers/microsoft.eventhub/namespaces/mynamespace/authorizationrules/myrule"),
                EventHubName = "myeventhub",
                Metrics =
{
new MetricSettings(true)
{
Category = "WorkflowMetrics",
RetentionPolicy = new RetentionPolicy(false,0),
}
},
                Logs =
{
new LogSettings(true)
{
CategoryGroup = "allLogs",
RetentionPolicy = new RetentionPolicy(false,0),
}
},
                WorkspaceId = new ResourceIdentifier(""),
                MarketplacePartnerId = new ResourceIdentifier("/subscriptions/abcdeabc-1234-1234-ab12-123a1234567a/resourceGroups/test-rg/providers/Microsoft.Datadog/monitors/dd1"),
                LogAnalyticsDestinationType = "Dedicated",
            };
            ArmOperation<DiagnosticSettingResource> lro = await diagnosticSetting.UpdateAsync(WaitUntil.Completed, data);
            DiagnosticSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Creates or Updates the diagnostic setting for category
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatesOrUpdatesTheDiagnosticSettingForCategory()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/preview/2021-05-01-preview/examples/createOrUpdateDiagnosticSettingCategory.json
            // this example is just showing the usage of "DiagnosticSettings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiagnosticSettingResource created on azure
            // for more information of creating DiagnosticSettingResource, please refer to the document of DiagnosticSettingResource
            string resourceUri = "subscriptions/1a66ce04-b633-4a0b-b2bc-a912ec8986a6/resourcegroups/viruela1/providers/microsoft.logic/workflows/viruela6";
            string name = "mysetting";
            ResourceIdentifier diagnosticSettingResourceId = DiagnosticSettingResource.CreateResourceIdentifier(resourceUri, name);
            DiagnosticSettingResource diagnosticSetting = client.GetDiagnosticSettingResource(diagnosticSettingResourceId);

            // invoke the operation
            DiagnosticSettingData data = new DiagnosticSettingData()
            {
                StorageAccountId = new ResourceIdentifier("/subscriptions/df602c9c-7aa0-407d-a6fb-eb20c8bd1192/resourceGroups/apptest/providers/Microsoft.Storage/storageAccounts/appteststorage1"),
                EventHubAuthorizationRuleId = new ResourceIdentifier("/subscriptions/1a66ce04-b633-4a0b-b2bc-a912ec8986a6/resourceGroups/montest/providers/microsoft.eventhub/namespaces/mynamespace/authorizationrules/myrule"),
                EventHubName = "myeventhub",
                Metrics =
{
new MetricSettings(true)
{
Category = "WorkflowMetrics",
RetentionPolicy = new RetentionPolicy(false,0),
}
},
                Logs =
{
new LogSettings(true)
{
Category = "WorkflowRuntime",
RetentionPolicy = new RetentionPolicy(false,0),
}
},
                WorkspaceId = new ResourceIdentifier(""),
                MarketplacePartnerId = new ResourceIdentifier("/subscriptions/abcdeabc-1234-1234-ab12-123a1234567a/resourceGroups/test-rg/providers/Microsoft.Datadog/monitors/dd1"),
                LogAnalyticsDestinationType = "Dedicated",
            };
            ArmOperation<DiagnosticSettingResource> lro = await diagnosticSetting.UpdateAsync(WaitUntil.Completed, data);
            DiagnosticSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes the diagnostic setting
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesTheDiagnosticSetting()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/preview/2021-05-01-preview/examples/deleteDiagnosticSetting.json
            // this example is just showing the usage of "DiagnosticSettings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DiagnosticSettingResource created on azure
            // for more information of creating DiagnosticSettingResource, please refer to the document of DiagnosticSettingResource
            string resourceUri = "subscriptions/1a66ce04-b633-4a0b-b2bc-a912ec8986a6/resourcegroups/viruela1/providers/microsoft.logic/workflows/viruela6";
            string name = "mysetting";
            ResourceIdentifier diagnosticSettingResourceId = DiagnosticSettingResource.CreateResourceIdentifier(resourceUri, name);
            DiagnosticSettingResource diagnosticSetting = client.GetDiagnosticSettingResource(diagnosticSettingResourceId);

            // invoke the operation
            await diagnosticSetting.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
