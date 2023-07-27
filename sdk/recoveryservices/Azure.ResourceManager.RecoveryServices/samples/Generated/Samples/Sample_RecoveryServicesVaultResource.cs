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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServices;
using Azure.ResourceManager.RecoveryServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServices.Samples
{
    public partial class Sample_RecoveryServicesVaultResource
    {
        // Download vault credential file
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateVaultCertificate_DownloadVaultCredentialFile()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/PUTVaultCred.json
            // this example is just showing the usage of "VaultCertificates_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-d41f-4550-9f70-7708a3a2283b";
            string resourceGroupName = "BCDRIbzRG";
            string vaultName = "BCDRIbzVault";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation
            string certificateName = "BCDRIbzVault77777777-d41f-4550-9f70-7708a3a2283b-12-18-2017-vaultcredentials";
            RecoveryServicesCertificateContent content = new RecoveryServicesCertificateContent()
            {
                Properties = new RawCertificateData()
                {
                    AuthType = RecoveryServicesAuthType.Aad,
                    Certificate = Convert.FromBase64String("TUlJRE5EQ0NBaHlnQXdJQkFnSVFDYUxFKzVTSlNVeWdncDM0VS9HUm9qQU5CZ2txaGtpRzl3MEJBUXNGQURBWE1SVXdFd1lEVlFRREV3eGhiV05vWVc1a2JpNWpiMjB3SGhjTk1qSXhNREkwTVRJd05qRTRXaGNOTWpNeE1ESTBNVEl4TmpFNFdqQVhNUlV3RXdZRFZRUURFd3hoYldOb1lXNWtiaTVqYjIwd2dnRWlNQTBHQ1NxR1NJYjNEUUVCQVFVQUE0SUJEd0F3Z2dFS0FvSUJBUUN4cFpwS293a2p4VU9VWkpLT2JvdGdPWXkzaW9UVkxMMmZyaW9nZVN1Qm5IMWw3aVdQWW9kUHRoWS8yVmh6ZFVUckNXL25pNUh3b0JHYzZMMHF6UGlBWXpHek94RmpMQjZjdFNkbm9nL1A4eEV2OGE0cnJWZlBZdS9INStoTGx3N0RubXlTNWs4TU9sSVhUemVWNkxZV2I2RWlpTFppc0k1R3lLU1liemNaQmJKdnhLTVdGdHRCV08xZUwzUWNUejlpb1VGQzVnRlFKQzg3YXFkeDR1Wk9WYzRLM3Ixb09sTFBKdmRLN25YU3VWci9ZOC80ZHhCdDJZUTRia0hjM2EzcUNBbTZrV0QzamRiajhCZmhlWWNVNjFFZ3llVFV2MlI4dzRubWJqVXZxRW05cDZtTG4xMTdEWWpQTHNFODVTL0FpQmF0dkNhQ3hCZ0lxb1N1blBOUkFnTUJBQUdqZkRCNk1BNEdBMVVkRHdFQi93UUVBd0lGb0RBSkJnTlZIUk1FQWpBQU1CMEdBMVVkSlFRV01CUUdDQ3NHQVFVRkJ3TUJCZ2dyQmdFRkJRY0RBakFmQmdOVkhTTUVHREFXZ0JRR1NZcDJMUTJwOE5wMHUzRThJZDdRUjRTQXBqQWRCZ05WSFE0RUZnUVVCa21LZGkwTnFmRGFkTHR4UENIZTBFZUVnS1l3RFFZSktvWklodmNOQVFFTEJRQURnZ0VCQUp2ZG9yRmJ4cExZaUhYRHpnR001WmxMWTRDZE1LYW5BdzVDZDNFVnhDbkhtT05ISnpLRmpzdHZjdUN1TDZ2S1ptci9abm5ENXNLUnE0d0xnTXV6dlNXNGtQTXlWeENrYzdVYnNZSWJCSXNIUDl3cUNmcUY5aG5LSE9YZFJJV2tBVXhnbmYxSlpLZjR1NlpTSzZ3dExaME9VT0c5Mmd3SlB2eW5PVmJoeWpqczdQTVpONEw1djZyeHJkRWp0WG5sYzIvRDlnS0NOTFhFZHdRM0dzS05ZTGZvYy9DT3JmbEIrRHVPSThrVzM0WmxzYlFHelgyQ3ArWVVlSDNrQlBjY3RpUWNURHFQcW5YS0NNMTJ6MGZDTjVpNXRkRlUrM0VzemZBQkpiOEZpU2ZCWFF1UUZRRDNDTDkraVdjZXhrMmxQako2akZIbHZtak9XbTdjQllHZlc4ST0="),
                },
            };
            VaultCertificateResult result = await recoveryServicesVault.CreateVaultCertificateAsync(certificateName, content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Delete registered Identity
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task DeleteRegisteredIdentity_DeleteRegisteredIdentity()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/DeleteRegisteredIdentities.json
            // this example is just showing the usage of "RegisteredIdentities_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-d41f-4550-9f70-7708a3a2283b";
            string resourceGroupName = "BCDRIbzRG";
            string vaultName = "BCDRIbzVault";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation
            string identityName = "dpmcontainer01";
            await recoveryServicesVault.DeleteRegisteredIdentityAsync(identityName);

            Console.WriteLine($"Succeeded");
        }

        // Gets Replication usages of vault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetReplicationUsages_GetsReplicationUsagesOfVault()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/ListReplicationUsages.json
            // this example is just showing the usage of "ReplicationUsages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "6808dbbc-98c7-431f-a1b1-9580902423b7";
            string resourceGroupName = "avrai7517RG1";
            string vaultName = "avrai7517Vault1";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation and iterate over the result
            await foreach (ReplicationUsage item in recoveryServicesVault.GetReplicationUsagesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List of Recovery Services Resources in SubscriptionId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRecoveryServicesVaults_ListOfRecoveryServicesResourcesInSubscriptionId()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/ListBySubscriptionIds.json
            // this example is just showing the usage of "Vaults_ListBySubscriptionId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (RecoveryServicesVaultResource item in subscriptionResource.GetRecoveryServicesVaultsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RecoveryServicesVaultData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Recovery Services Resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRecoveryServicesResource()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/GETVault.json
            // this example is just showing the usage of "Vaults_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "Default-RecoveryServices-ResourceGroup";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation
            RecoveryServicesVaultResource result = await recoveryServicesVault.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoveryServicesVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Recovery Services Vault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteRecoveryServicesVault()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/DeleteVault.json
            // this example is just showing the usage of "Vaults_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "Default-RecoveryServices-ResourceGroup";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation
            await recoveryServicesVault.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update Resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateResource()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/PATCHVault.json
            // this example is just showing the usage of "Vaults_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "HelloWorld";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation
            RecoveryServicesVaultPatch patch = new RecoveryServicesVaultPatch(new AzureLocation("placeholder"))
            {
                Tags =
{
["PatchKey"] = "PatchKeyUpdated",
},
            };
            ArmOperation<RecoveryServicesVaultResource> lro = await recoveryServicesVault.UpdateAsync(WaitUntil.Completed, patch);
            RecoveryServicesVaultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoveryServicesVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update Resource With CustomerManagedKeys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateResourceWithCustomerManagedKeys()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/PATCHVault_WithCMK.json
            // this example is just showing the usage of "Vaults_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "HelloWorld";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation
            RecoveryServicesVaultPatch patch = new RecoveryServicesVaultPatch(new AzureLocation("placeholder"))
            {
                Properties = new RecoveryServicesVaultProperties()
                {
                    Encryption = new VaultPropertiesEncryption()
                    {
                        KeyUri = new Uri("https://cmk2xkv.vault.azure.net/keys/Key1/0767b348bb1a4c07baa6c4ec0055d2b3"),
                        KekIdentity = new CmkKekIdentity()
                        {
                            UserAssignedIdentity = new ResourceIdentifier("/subscriptions/85bf5e8c-3084-4f42-add2-746ebb7e97b2/resourcegroups/defaultrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/examplemsi"),
                        },
                        InfrastructureEncryption = InfrastructureEncryptionState.Enabled,
                    },
                },
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/85bf5e8c-3084-4f42-add2-746ebb7e97b2/resourcegroups/defaultrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/examplemsi")] = new UserAssignedIdentity(),
},
                },
                Tags =
{
["PatchKey"] = "PatchKeyUpdated",
},
            };
            ArmOperation<RecoveryServicesVaultResource> lro = await recoveryServicesVault.UpdateAsync(WaitUntil.Completed, patch);
            RecoveryServicesVaultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoveryServicesVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update Resource With CustomerManagedKeys2
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateResourceWithCustomerManagedKeys2()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/PatchVault_WithCMK2.json
            // this example is just showing the usage of "Vaults_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "HelloWorld";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation
            RecoveryServicesVaultPatch patch = new RecoveryServicesVaultPatch(new AzureLocation("placeholder"))
            {
                Properties = new RecoveryServicesVaultProperties()
                {
                    Encryption = new VaultPropertiesEncryption()
                    {
                        KekIdentity = new CmkKekIdentity()
                        {
                            UseSystemAssignedIdentity = true,
                        },
                    },
                },
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                Tags =
{
["PatchKey"] = "PatchKeyUpdated",
},
            };
            ArmOperation<RecoveryServicesVaultResource> lro = await recoveryServicesVault.UpdateAsync(WaitUntil.Completed, patch);
            RecoveryServicesVaultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoveryServicesVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update Resource With CustomerManagedKeys3
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateResourceWithCustomerManagedKeys3()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/PATCHVault_WithCMK3.json
            // this example is just showing the usage of "Vaults_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "HelloWorld";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation
            RecoveryServicesVaultPatch patch = new RecoveryServicesVaultPatch(new AzureLocation("placeholder"))
            {
                Properties = new RecoveryServicesVaultProperties()
                {
                    Encryption = new VaultPropertiesEncryption()
                    {
                        KeyUri = new Uri("https://cmk2xkv.vault.azure.net/keys/Key1/0767b348bb1a4c07baa6c4ec0055d2b3"),
                    },
                },
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/85bf5e8c-3084-4f42-add2-746ebb7e97b2/resourcegroups/defaultrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/examplemsi")] = new UserAssignedIdentity(),
},
                },
                Tags =
{
["PatchKey"] = "PatchKeyUpdated",
},
            };
            ArmOperation<RecoveryServicesVaultResource> lro = await recoveryServicesVault.UpdateAsync(WaitUntil.Completed, patch);
            RecoveryServicesVaultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoveryServicesVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update Resource With User Assigned Identity
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateResourceWithUserAssignedIdentity()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/PATCHVault_WithUserAssignedIdentity.json
            // this example is just showing the usage of "Vaults_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "HelloWorld";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation
            RecoveryServicesVaultPatch patch = new RecoveryServicesVaultPatch(new AzureLocation("placeholder"))
            {
                Identity = new ManagedServiceIdentity("UserAssigned")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("/subscriptions/85bf5e8c-3084-4f42-add2-746ebb7e97b2/resourcegroups/defaultrg/providers/Microsoft.ManagedIdentity/userAssignedIdentities/examplemsi")] = new UserAssignedIdentity(),
},
                },
                Tags =
{
["PatchKey"] = "PatchKeyUpdated",
},
            };
            ArmOperation<RecoveryServicesVaultResource> lro = await recoveryServicesVault.UpdateAsync(WaitUntil.Completed, patch);
            RecoveryServicesVaultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoveryServicesVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update Vault With Monitoring Setting
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateVaultWithMonitoringSetting()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/PATCHVault_WithMonitoringSettings.json
            // this example is just showing the usage of "Vaults_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "HelloWorld";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation
            RecoveryServicesVaultPatch patch = new RecoveryServicesVaultPatch(new AzureLocation("placeholder"))
            {
                Properties = new RecoveryServicesVaultProperties()
                {
                    MonitoringSettings = new VaultMonitoringSettings()
                    {
                        AzureMonitorAlertAlertsForAllJobFailures = RecoveryServicesAlertsState.Enabled,
                        ClassicAlertAlertsForCriticalOperations = RecoveryServicesAlertsState.Disabled,
                    },
                },
                Tags =
{
["PatchKey"] = "PatchKeyUpdated",
},
            };
            ArmOperation<RecoveryServicesVaultResource> lro = await recoveryServicesVault.UpdateAsync(WaitUntil.Completed, patch);
            RecoveryServicesVaultResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RecoveryServicesVaultData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets vault usages
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUsagesByVaults_GetsVaultUsages()
        {
            // Generated from example definition: specification/recoveryservices/resource-manager/Microsoft.RecoveryServices/stable/2023-01-01/examples/ListUsages.json
            // this example is just showing the usage of "Usages_ListByVaults" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RecoveryServicesVaultResource created on azure
            // for more information of creating RecoveryServicesVaultResource, please refer to the document of RecoveryServicesVaultResource
            string subscriptionId = "77777777-b0c6-47a2-b37c-d8e65a629c18";
            string resourceGroupName = "Default-RecoveryServices-ResourceGroup";
            string vaultName = "swaggerExample";
            ResourceIdentifier recoveryServicesVaultResourceId = RecoveryServicesVaultResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName);
            RecoveryServicesVaultResource recoveryServicesVault = client.GetRecoveryServicesVaultResource(recoveryServicesVaultResourceId);

            // invoke the operation and iterate over the result
            await foreach (VaultUsage item in recoveryServicesVault.GetUsagesByVaultsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
