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
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_ScmSiteSlotBasicPublishingCredentialsPolicyResource
    {
        // Get SCM Allowed
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSCMAllowed()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/GetPublishingCredentialsPolicySlot.json
            // this example is just showing the usage of "WebApps_GetScmAllowedSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScmSiteSlotBasicPublishingCredentialsPolicyResource created on azure
            // for more information of creating ScmSiteSlotBasicPublishingCredentialsPolicyResource, please refer to the document of ScmSiteSlotBasicPublishingCredentialsPolicyResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testSite";
            string slot = "stage";
            ResourceIdentifier scmSiteSlotBasicPublishingCredentialsPolicyResourceId = ScmSiteSlotBasicPublishingCredentialsPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, slot);
            ScmSiteSlotBasicPublishingCredentialsPolicyResource scmSiteSlotBasicPublishingCredentialsPolicy = client.GetScmSiteSlotBasicPublishingCredentialsPolicyResource(scmSiteSlotBasicPublishingCredentialsPolicyResourceId);

            // invoke the operation
            ScmSiteSlotBasicPublishingCredentialsPolicyResource result = await scmSiteSlotBasicPublishingCredentialsPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CsmPublishingCredentialsPoliciesEntityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update SCM Allowed
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateSCMAllowed()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/UpdatePublishingCredentialsPolicySlot.json
            // this example is just showing the usage of "WebApps_UpdateScmAllowedSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScmSiteSlotBasicPublishingCredentialsPolicyResource created on azure
            // for more information of creating ScmSiteSlotBasicPublishingCredentialsPolicyResource, please refer to the document of ScmSiteSlotBasicPublishingCredentialsPolicyResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testSite";
            string slot = "stage";
            ResourceIdentifier scmSiteSlotBasicPublishingCredentialsPolicyResourceId = ScmSiteSlotBasicPublishingCredentialsPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, slot);
            ScmSiteSlotBasicPublishingCredentialsPolicyResource scmSiteSlotBasicPublishingCredentialsPolicy = client.GetScmSiteSlotBasicPublishingCredentialsPolicyResource(scmSiteSlotBasicPublishingCredentialsPolicyResourceId);

            // invoke the operation
            CsmPublishingCredentialsPoliciesEntityData data = new CsmPublishingCredentialsPoliciesEntityData()
            {
                Allow = true,
            };
            ArmOperation<ScmSiteSlotBasicPublishingCredentialsPolicyResource> lro = await scmSiteSlotBasicPublishingCredentialsPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            ScmSiteSlotBasicPublishingCredentialsPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CsmPublishingCredentialsPoliciesEntityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
