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
using Azure.ResourceManager.Relay;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay.Samples
{
    public partial class Sample_RelayNetworkRuleSetResource
    {
        // NameSpaceNetworkRuleSetCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_NameSpaceNetworkRuleSetCreate()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/VirtualNetworkRules/RelayNetworkRuleSetCreate.json
            // this example is just showing the usage of "Namespaces_CreateOrUpdateNetworkRuleSet" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayNetworkRuleSetResource created on azure
            // for more information of creating RelayNetworkRuleSetResource, please refer to the document of RelayNetworkRuleSetResource
            string subscriptionId = "Subscription";
            string resourceGroupName = "ResourceGroup";
            string namespaceName = "example-RelayNamespace-6019";
            ResourceIdentifier relayNetworkRuleSetResourceId = RelayNetworkRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            RelayNetworkRuleSetResource relayNetworkRuleSet = client.GetRelayNetworkRuleSetResource(relayNetworkRuleSetResourceId);

            // invoke the operation
            RelayNetworkRuleSetData data = new RelayNetworkRuleSetData()
            {
                DefaultAction = RelayNetworkRuleSetDefaultAction.Deny,
                IPRules =
{
new RelayNetworkRuleSetIPRule()
{
IPMask = "1.1.1.1",
Action = RelayNetworkRuleIPAction.Allow,
},new RelayNetworkRuleSetIPRule()
{
IPMask = "1.1.1.2",
Action = RelayNetworkRuleIPAction.Allow,
},new RelayNetworkRuleSetIPRule()
{
IPMask = "1.1.1.3",
Action = RelayNetworkRuleIPAction.Allow,
},new RelayNetworkRuleSetIPRule()
{
IPMask = "1.1.1.4",
Action = RelayNetworkRuleIPAction.Allow,
},new RelayNetworkRuleSetIPRule()
{
IPMask = "1.1.1.5",
Action = RelayNetworkRuleIPAction.Allow,
}
},
            };
            ArmOperation<RelayNetworkRuleSetResource> lro = await relayNetworkRuleSet.CreateOrUpdateAsync(WaitUntil.Completed, data);
            RelayNetworkRuleSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelayNetworkRuleSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NameSpaceNetworkRuleSetGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NameSpaceNetworkRuleSetGet()
        {
            // Generated from example definition: specification/relay/resource-manager/Microsoft.Relay/stable/2021-11-01/examples/VirtualNetworkRules/RelayNetworkRuleSetGet.json
            // this example is just showing the usage of "Namespaces_GetNetworkRuleSet" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RelayNetworkRuleSetResource created on azure
            // for more information of creating RelayNetworkRuleSetResource, please refer to the document of RelayNetworkRuleSetResource
            string subscriptionId = "Subscription";
            string resourceGroupName = "ResourceGroup";
            string namespaceName = "example-RelayNamespace-6019";
            ResourceIdentifier relayNetworkRuleSetResourceId = RelayNetworkRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            RelayNetworkRuleSetResource relayNetworkRuleSet = client.GetRelayNetworkRuleSetResource(relayNetworkRuleSetResourceId);

            // invoke the operation
            RelayNetworkRuleSetResource result = await relayNetworkRuleSet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RelayNetworkRuleSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
