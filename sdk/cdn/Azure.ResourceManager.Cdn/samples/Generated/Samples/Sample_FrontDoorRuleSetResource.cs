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
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_FrontDoorRuleSetResource
    {
        // RuleSets_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RuleSetsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/RuleSets_Get.json
            // this example is just showing the usage of "FrontDoorRuleSets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRuleSetResource created on azure
            // for more information of creating FrontDoorRuleSetResource, please refer to the document of FrontDoorRuleSetResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string ruleSetName = "ruleSet1";
            ResourceIdentifier frontDoorRuleSetResourceId = FrontDoorRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, ruleSetName);
            FrontDoorRuleSetResource frontDoorRuleSet = client.GetFrontDoorRuleSetResource(frontDoorRuleSetResourceId);

            // invoke the operation
            FrontDoorRuleSetResource result = await frontDoorRuleSet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorRuleSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RuleSets_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RuleSetsCreate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/RuleSets_Create.json
            // this example is just showing the usage of "FrontDoorRuleSets_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRuleSetResource created on azure
            // for more information of creating FrontDoorRuleSetResource, please refer to the document of FrontDoorRuleSetResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string ruleSetName = "ruleSet1";
            ResourceIdentifier frontDoorRuleSetResourceId = FrontDoorRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, ruleSetName);
            FrontDoorRuleSetResource frontDoorRuleSet = client.GetFrontDoorRuleSetResource(frontDoorRuleSetResourceId);

            // invoke the operation
            ArmOperation<FrontDoorRuleSetResource> lro = await frontDoorRuleSet.UpdateAsync(WaitUntil.Completed);
            FrontDoorRuleSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorRuleSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RuleSets_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RuleSetsDelete()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/RuleSets_Delete.json
            // this example is just showing the usage of "FrontDoorRuleSets_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRuleSetResource created on azure
            // for more information of creating FrontDoorRuleSetResource, please refer to the document of FrontDoorRuleSetResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string ruleSetName = "ruleSet1";
            ResourceIdentifier frontDoorRuleSetResourceId = FrontDoorRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, ruleSetName);
            FrontDoorRuleSetResource frontDoorRuleSet = client.GetFrontDoorRuleSetResource(frontDoorRuleSetResourceId);

            // invoke the operation
            await frontDoorRuleSet.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // RuleSets_ListResourceUsage
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetResourceUsages_RuleSetsListResourceUsage()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/RuleSets_ListResourceUsage.json
            // this example is just showing the usage of "FrontDoorRuleSets_ListResourceUsage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRuleSetResource created on azure
            // for more information of creating FrontDoorRuleSetResource, please refer to the document of FrontDoorRuleSetResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string ruleSetName = "ruleSet1";
            ResourceIdentifier frontDoorRuleSetResourceId = FrontDoorRuleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, ruleSetName);
            FrontDoorRuleSetResource frontDoorRuleSet = client.GetFrontDoorRuleSetResource(frontDoorRuleSetResourceId);

            // invoke the operation and iterate over the result
            await foreach (FrontDoorUsage item in frontDoorRuleSet.GetResourceUsagesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
