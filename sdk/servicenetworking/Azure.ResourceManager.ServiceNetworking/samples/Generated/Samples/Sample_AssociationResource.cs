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
using Azure.ResourceManager.ServiceNetworking;
using Azure.ResourceManager.ServiceNetworking.Models;

namespace Azure.ResourceManager.ServiceNetworking.Samples
{
    public partial class Sample_AssociationResource
    {
        // Get Association
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAssociation()
        {
            // Generated from example definition: specification/servicenetworking/resource-manager/Microsoft.ServiceNetworking/cadl/examples/AssociationGet.json
            // this example is just showing the usage of "AssociationsInterface_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssociationResource created on azure
            // for more information of creating AssociationResource, please refer to the document of AssociationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string trafficControllerName = "tc1";
            string associationName = "as1";
            ResourceIdentifier associationResourceId = AssociationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, trafficControllerName, associationName);
            AssociationResource association = client.GetAssociationResource(associationResourceId);

            // invoke the operation
            AssociationResource result = await association.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update Association
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAssociation()
        {
            // Generated from example definition: specification/servicenetworking/resource-manager/Microsoft.ServiceNetworking/cadl/examples/AssociationPatch.json
            // this example is just showing the usage of "AssociationsInterface_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssociationResource created on azure
            // for more information of creating AssociationResource, please refer to the document of AssociationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string trafficControllerName = "tc1";
            string associationName = "as1";
            ResourceIdentifier associationResourceId = AssociationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, trafficControllerName, associationName);
            AssociationResource association = client.GetAssociationResource(associationResourceId);

            // invoke the operation
            AssociationPatch patch = new AssociationPatch()
            {
                AssociationType = AssociationType.Subnets,
                SubnetId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/vnet-tc/subnets/tc-subnet"),
            };
            AssociationResource result = await association.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Association
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAssociation()
        {
            // Generated from example definition: specification/servicenetworking/resource-manager/Microsoft.ServiceNetworking/cadl/examples/AssociationDelete.json
            // this example is just showing the usage of "AssociationsInterface_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AssociationResource created on azure
            // for more information of creating AssociationResource, please refer to the document of AssociationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string trafficControllerName = "tc1";
            string associationName = "as1";
            ResourceIdentifier associationResourceId = AssociationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, trafficControllerName, associationName);
            AssociationResource association = client.GetAssociationResource(associationResourceId);

            // invoke the operation
            await association.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
