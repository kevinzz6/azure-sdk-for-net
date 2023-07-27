// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Samples
{
    public partial class Sample_BackupJobResource
    {
        // Get Job Details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetJobDetails()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-02-01/examples/Common/GetJobDetails.json
            // this example is just showing the usage of "JobDetails_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupJobResource created on azure
            // for more information of creating BackupJobResource, please refer to the document of BackupJobResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SwaggerTestRg";
            string vaultName = "NetSDKTestRsVault";
            string jobName = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier backupJobResourceId = BackupJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, jobName);
            BackupJobResource backupJob = client.GetBackupJobResource(backupJobResourceId);

            // invoke the operation
            BackupJobResource result = await backupJob.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Cancel Job
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task TriggerJobCancellation_CancelJob()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-02-01/examples/Common/TriggerCancelJob.json
            // this example is just showing the usage of "JobCancellations_Trigger" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupJobResource created on azure
            // for more information of creating BackupJobResource, please refer to the document of BackupJobResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SwaggerTestRg";
            string vaultName = "NetSDKTestRsVault";
            string jobName = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier backupJobResourceId = BackupJobResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, jobName);
            BackupJobResource backupJob = client.GetBackupJobResource(backupJobResourceId);

            // invoke the operation
            await backupJob.TriggerJobCancellationAsync();

            Console.WriteLine($"Succeeded");
        }
    }
}
