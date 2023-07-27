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
using Azure.ResourceManager.Media;
using Azure.ResourceManager.Media.Models;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_MediaTransformResource
    {
        // Get a Transform by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetATransformByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/transforms-get-by-name.json
            // this example is just showing the usage of "Transforms_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "sampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // invoke the operation
            MediaTransformResource result = await mediaTransform.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaTransformData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a Transform
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteATransform()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/transforms-delete.json
            // this example is just showing the usage of "Transforms_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "sampleTransform";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // invoke the operation
            await mediaTransform.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update a Transform.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateATransform()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/transforms-update.json
            // this example is just showing the usage of "Transforms_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaTransformResource created on azure
            // for more information of creating MediaTransformResource, please refer to the document of MediaTransformResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            string transformName = "transformToUpdate";
            ResourceIdentifier mediaTransformResourceId = MediaTransformResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, transformName);
            MediaTransformResource mediaTransform = client.GetMediaTransformResource(mediaTransformResourceId);

            // invoke the operation
            MediaTransformData data = new MediaTransformData()
            {
                Description = "Example transform to illustrate update.",
                Outputs =
{
new MediaTransformOutput(new BuiltInStandardEncoderPreset(EncoderNamedPreset.H264MultipleBitrate720P))
{
RelativePriority = MediaJobPriority.High,
}
},
            };
            MediaTransformResource result = await mediaTransform.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaTransformData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
