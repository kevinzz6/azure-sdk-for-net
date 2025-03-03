// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Automation.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_AutomationConnectionTypeCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateConnectionType()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/createOrUpdateConnectionType.json
            // this example is just showing the usage of "ConnectionType_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount22";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionTypeResource
            AutomationConnectionTypeCollection collection = automationAccount.GetAutomationConnectionTypes();

            // invoke the operation
            string connectionTypeName = "myCT";
            AutomationConnectionTypeCreateOrUpdateContent content = new AutomationConnectionTypeCreateOrUpdateContent("myCT", new Dictionary<string, AutomationConnectionFieldDefinition>
            {
                ["myBoolField"] = new AutomationConnectionFieldDefinition("bool")
                {
                    IsEncrypted = false,
                    IsOptional = false,
                },
                ["myStringField"] = new AutomationConnectionFieldDefinition("string")
                {
                    IsEncrypted = false,
                    IsOptional = false,
                },
                ["myStringFieldEncrypted"] = new AutomationConnectionFieldDefinition("string")
                {
                    IsEncrypted = true,
                    IsOptional = false,
                }
            })
            {
                IsGlobal = false,
            };
            ArmOperation<AutomationConnectionTypeResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, connectionTypeName, content);
            AutomationConnectionTypeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationConnectionTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetConnectionType()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getConnectionType.json
            // this example is just showing the usage of "ConnectionType_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount22";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionTypeResource
            AutomationConnectionTypeCollection collection = automationAccount.GetAutomationConnectionTypes();

            // invoke the operation
            string connectionTypeName = "myCT";
            AutomationConnectionTypeResource result = await collection.GetAsync(connectionTypeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationConnectionTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetConnectionTypesFirst100()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getAllConnectionTypes_First100.json
            // this example is just showing the usage of "ConnectionType_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount25";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionTypeResource
            AutomationConnectionTypeCollection collection = automationAccount.GetAutomationConnectionTypes();

            // invoke the operation and iterate over the result
            await foreach (AutomationConnectionTypeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationConnectionTypeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetConnectionTypesNext100()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getAllConnectionTypes_Next100.json
            // this example is just showing the usage of "ConnectionType_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount25";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionTypeResource
            AutomationConnectionTypeCollection collection = automationAccount.GetAutomationConnectionTypes();

            // invoke the operation and iterate over the result
            await foreach (AutomationConnectionTypeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationConnectionTypeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetConnectionType()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getConnectionType.json
            // this example is just showing the usage of "ConnectionType_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount22";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionTypeResource
            AutomationConnectionTypeCollection collection = automationAccount.GetAutomationConnectionTypes();

            // invoke the operation
            string connectionTypeName = "myCT";
            bool result = await collection.ExistsAsync(connectionTypeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetConnectionType()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getConnectionType.json
            // this example is just showing the usage of "ConnectionType_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount22";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationConnectionTypeResource
            AutomationConnectionTypeCollection collection = automationAccount.GetAutomationConnectionTypes();

            // invoke the operation
            string connectionTypeName = "myCT";
            NullableResponse<AutomationConnectionTypeResource> response = await collection.GetIfExistsAsync(connectionTypeName);
            AutomationConnectionTypeResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationConnectionTypeData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
