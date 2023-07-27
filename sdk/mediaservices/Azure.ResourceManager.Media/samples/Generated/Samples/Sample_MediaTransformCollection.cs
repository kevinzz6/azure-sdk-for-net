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
    public partial class Sample_MediaTransformCollection
    {
        // Lists the Transforms
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsTheTransforms()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/transforms-list-all.json
            // this example is just showing the usage of "Transforms_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaTransformResource
            MediaTransformCollection collection = mediaServicesAccount.GetMediaTransforms();

            // invoke the operation and iterate over the result
            await foreach (MediaTransformResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaTransformData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Lists the Transforms filter by created
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsTheTransformsFilterByCreated()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/transforms-list-all-filter-by-created.json
            // this example is just showing the usage of "Transforms_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaTransformResource
            MediaTransformCollection collection = mediaServicesAccount.GetMediaTransforms();

            // invoke the operation and iterate over the result
            string filter = "properties/created gt 2021-06-01T00:00:00.0000000Z and properties/created le 2021-06-01T00:00:10.0000000Z";
            string orderby = "properties/created";
            await foreach (MediaTransformResource item in collection.GetAllAsync(filter: filter, orderby: orderby))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaTransformData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Lists the Transforms filter by lastmodified
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsTheTransformsFilterByLastmodified()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/transforms-list-all-filter-by-lastmodified.json
            // this example is just showing the usage of "Transforms_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaTransformResource
            MediaTransformCollection collection = mediaServicesAccount.GetMediaTransforms();

            // invoke the operation and iterate over the result
            string filter = "properties/lastmodified gt 2021-06-01T00:00:00.0000000Z and properties/lastmodified le 2021-06-01T00:00:10.0000000Z";
            string orderby = "properties/lastmodified desc";
            await foreach (MediaTransformResource item in collection.GetAllAsync(filter: filter, orderby: orderby))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaTransformData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Lists the Transforms filter by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsTheTransformsFilterByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/transforms-list-all-filter-by-name.json
            // this example is just showing the usage of "Transforms_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaTransformResource
            MediaTransformCollection collection = mediaServicesAccount.GetMediaTransforms();

            // invoke the operation and iterate over the result
            string filter = "(name eq 'sampleEncode') or (name eq 'sampleEncodeAndVideoIndex')";
            string orderby = "name desc";
            await foreach (MediaTransformResource item in collection.GetAllAsync(filter: filter, orderby: orderby))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaTransformData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

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

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaTransformResource
            MediaTransformCollection collection = mediaServicesAccount.GetMediaTransforms();

            // invoke the operation
            string transformName = "sampleTransform";
            MediaTransformResource result = await collection.GetAsync(transformName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaTransformData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a Transform by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetATransformByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/transforms-get-by-name.json
            // this example is just showing the usage of "Transforms_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaTransformResource
            MediaTransformCollection collection = mediaServicesAccount.GetMediaTransforms();

            // invoke the operation
            string transformName = "sampleTransform";
            bool result = await collection.ExistsAsync(transformName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create or update a Transform
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateATransform()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Encoding/stable/2022-07-01/examples/transforms-create.json
            // this example is just showing the usage of "Transforms_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaServicesAccountResource created on azure
            // for more information of creating MediaServicesAccountResource, please refer to the document of MediaServicesAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contosoresources";
            string accountName = "contosomedia";
            ResourceIdentifier mediaServicesAccountResourceId = MediaServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            MediaServicesAccountResource mediaServicesAccount = client.GetMediaServicesAccountResource(mediaServicesAccountResourceId);

            // get the collection of this MediaTransformResource
            MediaTransformCollection collection = mediaServicesAccount.GetMediaTransforms();

            // invoke the operation
            string transformName = "createdTransform";
            MediaTransformData data = new MediaTransformData()
            {
                Description = "Example Transform to illustrate create and update.",
                Outputs =
{
new MediaTransformOutput(new BuiltInStandardEncoderPreset(EncoderNamedPreset.AdaptiveStreaming))
},
            };
            ArmOperation<MediaTransformResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, transformName, data);
            MediaTransformResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaTransformData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
