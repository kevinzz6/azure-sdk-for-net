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
using Azure.ResourceManager.Synapse;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseDatabasePrincipalAssignmentResource
    {
        // KustoPoolDatabasePrincipalAssignmentsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KustoPoolDatabasePrincipalAssignmentsGet()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDatabasePrincipalAssignmentsGet.json
            // this example is just showing the usage of "KustoPoolDatabasePrincipalAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDatabasePrincipalAssignmentResource created on azure
            // for more information of creating SynapseDatabasePrincipalAssignmentResource, please refer to the document of SynapseDatabasePrincipalAssignmentResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "Kustodatabase8";
            string principalAssignmentName = "kustoprincipal1";
            ResourceIdentifier synapseDatabasePrincipalAssignmentResourceId = SynapseDatabasePrincipalAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, principalAssignmentName);
            SynapseDatabasePrincipalAssignmentResource synapseDatabasePrincipalAssignment = client.GetSynapseDatabasePrincipalAssignmentResource(synapseDatabasePrincipalAssignmentResourceId);

            // invoke the operation
            SynapseDatabasePrincipalAssignmentResource result = await synapseDatabasePrincipalAssignment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDatabasePrincipalAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoPoolDatabasePrincipalAssignmentsCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_KustoPoolDatabasePrincipalAssignmentsCreateOrUpdate()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDatabasePrincipalAssignmentsCreateOrUpdate.json
            // this example is just showing the usage of "KustoPoolDatabasePrincipalAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDatabasePrincipalAssignmentResource created on azure
            // for more information of creating SynapseDatabasePrincipalAssignmentResource, please refer to the document of SynapseDatabasePrincipalAssignmentResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "Kustodatabase8";
            string principalAssignmentName = "kustoprincipal1";
            ResourceIdentifier synapseDatabasePrincipalAssignmentResourceId = SynapseDatabasePrincipalAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, principalAssignmentName);
            SynapseDatabasePrincipalAssignmentResource synapseDatabasePrincipalAssignment = client.GetSynapseDatabasePrincipalAssignmentResource(synapseDatabasePrincipalAssignmentResourceId);

            // invoke the operation
            SynapseDatabasePrincipalAssignmentData data = new SynapseDatabasePrincipalAssignmentData()
            {
                PrincipalId = "87654321-1234-1234-1234-123456789123",
                Role = SynapseDatabasePrincipalRole.Admin,
                TenantId = Guid.Parse("12345678-1234-1234-1234-123456789123"),
                PrincipalType = SynapsePrincipalType.App,
            };
            ArmOperation<SynapseDatabasePrincipalAssignmentResource> lro = await synapseDatabasePrincipalAssignment.UpdateAsync(WaitUntil.Completed, data);
            SynapseDatabasePrincipalAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDatabasePrincipalAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoPoolDatabasePrincipalAssignmentsDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_KustoPoolDatabasePrincipalAssignmentsDelete()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDatabasePrincipalAssignmentsDelete.json
            // this example is just showing the usage of "KustoPoolDatabasePrincipalAssignments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDatabasePrincipalAssignmentResource created on azure
            // for more information of creating SynapseDatabasePrincipalAssignmentResource, please refer to the document of SynapseDatabasePrincipalAssignmentResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "Kustodatabase8";
            string principalAssignmentName = "kustoprincipal1";
            ResourceIdentifier synapseDatabasePrincipalAssignmentResourceId = SynapseDatabasePrincipalAssignmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName, principalAssignmentName);
            SynapseDatabasePrincipalAssignmentResource synapseDatabasePrincipalAssignment = client.GetSynapseDatabasePrincipalAssignmentResource(synapseDatabasePrincipalAssignmentResourceId);

            // invoke the operation
            await synapseDatabasePrincipalAssignment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
