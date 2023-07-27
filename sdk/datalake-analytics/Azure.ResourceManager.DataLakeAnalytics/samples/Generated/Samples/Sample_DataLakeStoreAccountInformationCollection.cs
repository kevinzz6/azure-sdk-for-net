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
using Azure.ResourceManager.DataLakeAnalytics;
using Azure.ResourceManager.DataLakeAnalytics.Models;

namespace Azure.ResourceManager.DataLakeAnalytics.Samples
{
    public partial class Sample_DataLakeStoreAccountInformationCollection
    {
        // Gets the first page of Data Lake Store accounts linked to the specified Data Lake Analytics account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetsTheFirstPageOfDataLakeStoreAccountsLinkedToTheSpecifiedDataLakeAnalyticsAccount()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/DataLakeStoreAccounts_ListByAccount.json
            // this example is just showing the usage of "DataLakeStoreAccounts_ListByAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataLakeAnalyticsAccountResource created on azure
            // for more information of creating DataLakeAnalyticsAccountResource, please refer to the document of DataLakeAnalyticsAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeAnalyticsAccountResourceId = DataLakeAnalyticsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeAnalyticsAccountResource dataLakeAnalyticsAccount = client.GetDataLakeAnalyticsAccountResource(dataLakeAnalyticsAccountResourceId);

            // get the collection of this DataLakeStoreAccountInformationResource
            DataLakeStoreAccountInformationCollection collection = dataLakeAnalyticsAccount.GetAllDataLakeStoreAccountInformation();

            // invoke the operation and iterate over the result
            DataLakeStoreAccountInformationCollectionGetAllOptions options = new DataLakeStoreAccountInformationCollectionGetAllOptions() { Filter = "test_filter", Top = 1, Skip = 1, Select = "test_select", Orderby = "test_orderby", Count = false };
            await foreach (DataLakeStoreAccountInformationResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataLakeStoreAccountInformationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Adds a Data Lake Store account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_AddsADataLakeStoreAccount()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/DataLakeStoreAccounts_Add.json
            // this example is just showing the usage of "DataLakeStoreAccounts_Add" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataLakeAnalyticsAccountResource created on azure
            // for more information of creating DataLakeAnalyticsAccountResource, please refer to the document of DataLakeAnalyticsAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeAnalyticsAccountResourceId = DataLakeAnalyticsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeAnalyticsAccountResource dataLakeAnalyticsAccount = client.GetDataLakeAnalyticsAccountResource(dataLakeAnalyticsAccountResourceId);

            // get the collection of this DataLakeStoreAccountInformationResource
            DataLakeStoreAccountInformationCollection collection = dataLakeAnalyticsAccount.GetAllDataLakeStoreAccountInformation();

            // invoke the operation
            string dataLakeStoreAccountName = "test_adls_account";
            DataLakeStoreAccountInformationCreateOrUpdateContent content = new DataLakeStoreAccountInformationCreateOrUpdateContent()
            {
                Suffix = "test_suffix",
            };
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataLakeStoreAccountName, content);

            Console.WriteLine($"Succeeded");
        }

        // Gets the specified Data Lake Store account details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheSpecifiedDataLakeStoreAccountDetails()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/DataLakeStoreAccounts_Get.json
            // this example is just showing the usage of "DataLakeStoreAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataLakeAnalyticsAccountResource created on azure
            // for more information of creating DataLakeAnalyticsAccountResource, please refer to the document of DataLakeAnalyticsAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1669ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeAnalyticsAccountResourceId = DataLakeAnalyticsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeAnalyticsAccountResource dataLakeAnalyticsAccount = client.GetDataLakeAnalyticsAccountResource(dataLakeAnalyticsAccountResourceId);

            // get the collection of this DataLakeStoreAccountInformationResource
            DataLakeStoreAccountInformationCollection collection = dataLakeAnalyticsAccount.GetAllDataLakeStoreAccountInformation();

            // invoke the operation
            string dataLakeStoreAccountName = "test_adls_account";
            DataLakeStoreAccountInformationResource result = await collection.GetAsync(dataLakeStoreAccountName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataLakeStoreAccountInformationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets the specified Data Lake Store account details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsTheSpecifiedDataLakeStoreAccountDetails()
        {
            // Generated from example definition: specification/datalake-analytics/resource-manager/Microsoft.DataLakeAnalytics/stable/2016-11-01/examples/DataLakeStoreAccounts_Get.json
            // this example is just showing the usage of "DataLakeStoreAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataLakeAnalyticsAccountResource created on azure
            // for more information of creating DataLakeAnalyticsAccountResource, please refer to the document of DataLakeAnalyticsAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1669ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeAnalyticsAccountResourceId = DataLakeAnalyticsAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeAnalyticsAccountResource dataLakeAnalyticsAccount = client.GetDataLakeAnalyticsAccountResource(dataLakeAnalyticsAccountResourceId);

            // get the collection of this DataLakeStoreAccountInformationResource
            DataLakeStoreAccountInformationCollection collection = dataLakeAnalyticsAccount.GetAllDataLakeStoreAccountInformation();

            // invoke the operation
            string dataLakeStoreAccountName = "test_adls_account";
            bool result = await collection.ExistsAsync(dataLakeStoreAccountName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
