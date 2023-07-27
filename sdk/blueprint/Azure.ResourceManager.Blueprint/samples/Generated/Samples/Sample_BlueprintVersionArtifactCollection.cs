// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Blueprint;

namespace Azure.ResourceManager.Blueprint.Samples
{
    public partial class Sample_BlueprintVersionArtifactCollection
    {
        // MG-ARMTemplateArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_MGARMTemplateArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedARMTemplateArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "storageTemplate";
            BlueprintVersionArtifactResource result = await collection.GetAsync(artifactName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArtifactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // MG-ARMTemplateArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_MGARMTemplateArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedARMTemplateArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "storageTemplate";
            bool result = await collection.ExistsAsync(artifactName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // MG-PolicyAssignmentArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_MGPolicyAssignmentArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedPolicyAssignmentArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "costCenterPolicy";
            BlueprintVersionArtifactResource result = await collection.GetAsync(artifactName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArtifactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // MG-PolicyAssignmentArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_MGPolicyAssignmentArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedPolicyAssignmentArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "costCenterPolicy";
            bool result = await collection.ExistsAsync(artifactName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // MG-RoleAssignmentArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_MGRoleAssignmentArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedRoleAssignmentArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "ownerAssignment";
            BlueprintVersionArtifactResource result = await collection.GetAsync(artifactName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArtifactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // MG-RoleAssignmentArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_MGRoleAssignmentArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedRoleAssignmentArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "ownerAssignment";
            bool result = await collection.ExistsAsync(artifactName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Sub-ARMTemplateArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SubARMTemplateArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedARMTemplateArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "storageTemplate";
            BlueprintVersionArtifactResource result = await collection.GetAsync(artifactName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArtifactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Sub-ARMTemplateArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SubARMTemplateArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedARMTemplateArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "storageTemplate";
            bool result = await collection.ExistsAsync(artifactName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Sub-PolicyAssignmentArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SubPolicyAssignmentArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedPolicyAssignmentArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "costCenterPolicy";
            BlueprintVersionArtifactResource result = await collection.GetAsync(artifactName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArtifactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Sub-PolicyAssignmentArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SubPolicyAssignmentArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedPolicyAssignmentArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "costCenterPolicy";
            bool result = await collection.ExistsAsync(artifactName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Sub-RoleAssignmentArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SubRoleAssignmentArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedRoleAssignmentArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "ownerAssignment";
            BlueprintVersionArtifactResource result = await collection.GetAsync(artifactName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArtifactData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Sub-RoleAssignmentArtifact
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SubRoleAssignmentArtifact()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedRoleAssignmentArtifact_Get.json
            // this example is just showing the usage of "PublishedArtifacts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation
            string artifactName = "ownerAssignment";
            bool result = await collection.ExistsAsync(artifactName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // MG-ArtifactList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_MGArtifactList()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/managementGroupBPDef/SealedArtifact_List.json
            // this example is just showing the usage of "PublishedArtifacts_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "providers/Microsoft.Management/managementGroups/ContosoOnlineGroup";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation and iterate over the result
            await foreach (BlueprintVersionArtifactResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ArtifactData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Sub-ArtifactList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SubArtifactList()
        {
            // Generated from example definition: specification/blueprint/resource-manager/Microsoft.Blueprint/preview/2018-11-01-preview/examples/subscriptionBPDef/SealedArtifact_List.json
            // this example is just showing the usage of "PublishedArtifacts_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PublishedBlueprintResource created on azure
            // for more information of creating PublishedBlueprintResource, please refer to the document of PublishedBlueprintResource
            string resourceScope = "subscriptions/00000000-0000-0000-0000-000000000000";
            string blueprintName = "simpleBlueprint";
            string versionId = "V2";
            ResourceIdentifier publishedBlueprintResourceId = PublishedBlueprintResource.CreateResourceIdentifier(resourceScope, blueprintName, versionId);
            PublishedBlueprintResource publishedBlueprint = client.GetPublishedBlueprintResource(publishedBlueprintResourceId);

            // get the collection of this BlueprintVersionArtifactResource
            BlueprintVersionArtifactCollection collection = publishedBlueprint.GetBlueprintVersionArtifacts();

            // invoke the operation and iterate over the result
            await foreach (BlueprintVersionArtifactResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ArtifactData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
