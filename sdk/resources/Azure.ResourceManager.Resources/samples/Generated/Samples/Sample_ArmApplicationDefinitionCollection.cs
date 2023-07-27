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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources.Samples
{
    public partial class Sample_ArmApplicationDefinitionCollection
    {
        // Get managed application definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetManagedApplicationDefinition()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Solutions/stable/2019-07-01/examples/getApplicationDefinition.json
            // this example is just showing the usage of "ApplicationDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmApplicationDefinitionResource
            ArmApplicationDefinitionCollection collection = resourceGroupResource.GetArmApplicationDefinitions();

            // invoke the operation
            string applicationDefinitionName = "myManagedApplicationDef";
            ArmApplicationDefinitionResource result = await collection.GetAsync(applicationDefinitionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArmApplicationDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get managed application definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetManagedApplicationDefinition()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Solutions/stable/2019-07-01/examples/getApplicationDefinition.json
            // this example is just showing the usage of "ApplicationDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmApplicationDefinitionResource
            ArmApplicationDefinitionCollection collection = resourceGroupResource.GetArmApplicationDefinitions();

            // invoke the operation
            string applicationDefinitionName = "myManagedApplicationDef";
            bool result = await collection.ExistsAsync(applicationDefinitionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create or update managed application definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateManagedApplicationDefinition()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Solutions/stable/2019-07-01/examples/createOrUpdateApplicationDefinition.json
            // this example is just showing the usage of "ApplicationDefinitions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmApplicationDefinitionResource
            ArmApplicationDefinitionCollection collection = resourceGroupResource.GetArmApplicationDefinitions();

            // invoke the operation
            string applicationDefinitionName = "myManagedApplicationDef";
            ArmApplicationDefinitionData data = new ArmApplicationDefinitionData(new AzureLocation("East US 2"), ArmApplicationLockLevel.None)
            {
                DisplayName = "myManagedApplicationDef",
                Authorizations =
{
new ArmApplicationAuthorization(Guid.Parse("validprincipalguid"),"validroleguid")
},
                Description = "myManagedApplicationDef description",
                PackageFileUri = new Uri("https://path/to/packagezipfile"),
            };
            ArmOperation<ArmApplicationDefinitionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationDefinitionName, data);
            ArmApplicationDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArmApplicationDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List managed application definitions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListManagedApplicationDefinitions()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Solutions/stable/2019-07-01/examples/listApplicationDefinitionsByResourceGroup.json
            // this example is just showing the usage of "ApplicationDefinitions_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmApplicationDefinitionResource
            ArmApplicationDefinitionCollection collection = resourceGroupResource.GetArmApplicationDefinitions();

            // invoke the operation and iterate over the result
            await foreach (ArmApplicationDefinitionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ArmApplicationDefinitionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
