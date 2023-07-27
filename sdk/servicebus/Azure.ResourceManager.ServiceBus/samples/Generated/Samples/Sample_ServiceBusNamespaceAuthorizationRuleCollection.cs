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
using Azure.ResourceManager.ServiceBus;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus.Samples
{
    public partial class Sample_ServiceBusNamespaceAuthorizationRuleCollection
    {
        // NameSpaceAuthorizationRuleListAll
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_NameSpaceAuthorizationRuleListAll()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/SBNameSpaceAuthorizationRuleListAll.json
            // this example is just showing the usage of "NamespaceAuthorizationRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6914";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusNamespaceAuthorizationRuleResource
            ServiceBusNamespaceAuthorizationRuleCollection collection = serviceBusNamespace.GetServiceBusNamespaceAuthorizationRules();

            // invoke the operation and iterate over the result
            await foreach (ServiceBusNamespaceAuthorizationRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceBusAuthorizationRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // NameSpaceAuthorizationRuleCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_NameSpaceAuthorizationRuleCreate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/SBNameSpaceAuthorizationRuleCreate.json
            // this example is just showing the usage of "NamespaceAuthorizationRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6914";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusNamespaceAuthorizationRuleResource
            ServiceBusNamespaceAuthorizationRuleCollection collection = serviceBusNamespace.GetServiceBusNamespaceAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-AuthRules-1788";
            ServiceBusAuthorizationRuleData data = new ServiceBusAuthorizationRuleData()
            {
                Rights =
{
ServiceBusAccessRight.Listen,ServiceBusAccessRight.Send
},
            };
            ArmOperation<ServiceBusNamespaceAuthorizationRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationRuleName, data);
            ServiceBusNamespaceAuthorizationRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpaceAuthorizationRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NameSpaceAuthorizationRuleGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/SBNameSpaceAuthorizationRuleGet.json
            // this example is just showing the usage of "NamespaceAuthorizationRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6914";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusNamespaceAuthorizationRuleResource
            ServiceBusNamespaceAuthorizationRuleCollection collection = serviceBusNamespace.GetServiceBusNamespaceAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-AuthRules-1788";
            ServiceBusNamespaceAuthorizationRuleResource result = await collection.GetAsync(authorizationRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusAuthorizationRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpaceAuthorizationRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_NameSpaceAuthorizationRuleGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/preview/2022-10-01-preview/examples/NameSpaces/SBNameSpaceAuthorizationRuleGet.json
            // this example is just showing the usage of "NamespaceAuthorizationRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusNamespaceResource created on azure
            // for more information of creating ServiceBusNamespaceResource, please refer to the document of ServiceBusNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-6914";
            ResourceIdentifier serviceBusNamespaceResourceId = ServiceBusNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            ServiceBusNamespaceResource serviceBusNamespace = client.GetServiceBusNamespaceResource(serviceBusNamespaceResourceId);

            // get the collection of this ServiceBusNamespaceAuthorizationRuleResource
            ServiceBusNamespaceAuthorizationRuleCollection collection = serviceBusNamespace.GetServiceBusNamespaceAuthorizationRules();

            // invoke the operation
            string authorizationRuleName = "sdk-AuthRules-1788";
            bool result = await collection.ExistsAsync(authorizationRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
