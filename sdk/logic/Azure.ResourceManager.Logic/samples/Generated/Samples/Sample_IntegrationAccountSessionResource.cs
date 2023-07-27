// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_IntegrationAccountSessionResource
    {
        // Get an integration account session
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnIntegrationAccountSession()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSessions_Get.json
            // this example is just showing the usage of "IntegrationAccountSessions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountSessionResource created on azure
            // for more information of creating IntegrationAccountSessionResource, please refer to the document of IntegrationAccountSessionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string integrationAccountName = "testia123";
            string sessionName = "testsession123-ICN";
            ResourceIdentifier integrationAccountSessionResourceId = IntegrationAccountSessionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, sessionName);
            IntegrationAccountSessionResource integrationAccountSession = client.GetIntegrationAccountSessionResource(integrationAccountSessionResourceId);

            // invoke the operation
            IntegrationAccountSessionResource result = await integrationAccountSession.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountSessionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update an integration account session
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateAnIntegrationAccountSession()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSessions_CreateOrUpdate.json
            // this example is just showing the usage of "IntegrationAccountSessions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountSessionResource created on azure
            // for more information of creating IntegrationAccountSessionResource, please refer to the document of IntegrationAccountSessionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string integrationAccountName = "testia123";
            string sessionName = "testsession123-ICN";
            ResourceIdentifier integrationAccountSessionResourceId = IntegrationAccountSessionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, sessionName);
            IntegrationAccountSessionResource integrationAccountSession = client.GetIntegrationAccountSessionResource(integrationAccountSessionResourceId);

            // invoke the operation
            IntegrationAccountSessionData data = new IntegrationAccountSessionData(new AzureLocation("placeholder"))
            {
                Content = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                    ["controlNumber"] = "1234",
                    ["controlNumberChangedTime"] = "2017-02-21T22:30:11.9923759Z"
                }),
            };
            ArmOperation<IntegrationAccountSessionResource> lro = await integrationAccountSession.UpdateAsync(WaitUntil.Completed, data);
            IntegrationAccountSessionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountSessionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete an integration account session
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAnIntegrationAccountSession()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSessions_Delete.json
            // this example is just showing the usage of "IntegrationAccountSessions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountSessionResource created on azure
            // for more information of creating IntegrationAccountSessionResource, please refer to the document of IntegrationAccountSessionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string integrationAccountName = "testia123";
            string sessionName = "testsession123-ICN";
            ResourceIdentifier integrationAccountSessionResourceId = IntegrationAccountSessionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName, sessionName);
            IntegrationAccountSessionResource integrationAccountSession = client.GetIntegrationAccountSessionResource(integrationAccountSessionResourceId);

            // invoke the operation
            await integrationAccountSession.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
