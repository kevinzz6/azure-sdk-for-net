// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_SubscriptionSecurityAlertResource
    {
        // Get security alert on a subscription from a security data location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSecurityAlertOnASubscriptionFromASecurityDataLocation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2022-01-01/examples/Alerts/GetAlertSubscriptionLocation_example.json
            // this example is just showing the usage of "Alerts_GetSubscriptionLevel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSecurityAlertResource created on azure
            // for more information of creating SubscriptionSecurityAlertResource, please refer to the document of SubscriptionSecurityAlertResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            AzureLocation ascLocation = new AzureLocation("westeurope");
            string alertName = "2518770965529163669_F144EE95-A3E5-42DA-A279-967D115809AA";
            ResourceIdentifier subscriptionSecurityAlertResourceId = SubscriptionSecurityAlertResource.CreateResourceIdentifier(subscriptionId, ascLocation, alertName);
            SubscriptionSecurityAlertResource subscriptionSecurityAlert = client.GetSubscriptionSecurityAlertResource(subscriptionSecurityAlertResourceId);

            // invoke the operation
            SubscriptionSecurityAlertResource result = await subscriptionSecurityAlert.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityAlertData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update security alert state on a subscription from a security data location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Dismiss_UpdateSecurityAlertStateOnASubscriptionFromASecurityDataLocation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2022-01-01/examples/Alerts/UpdateAlertSubscriptionLocation_dismiss_example.json
            // this example is just showing the usage of "Alerts_UpdateSubscriptionLevelStateToDismiss" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSecurityAlertResource created on azure
            // for more information of creating SubscriptionSecurityAlertResource, please refer to the document of SubscriptionSecurityAlertResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            AzureLocation ascLocation = new AzureLocation("westeurope");
            string alertName = "2518298467986649999_4d25bfef-2d77-4a08-adc0-3e35715cc92a";
            ResourceIdentifier subscriptionSecurityAlertResourceId = SubscriptionSecurityAlertResource.CreateResourceIdentifier(subscriptionId, ascLocation, alertName);
            SubscriptionSecurityAlertResource subscriptionSecurityAlert = client.GetSubscriptionSecurityAlertResource(subscriptionSecurityAlertResourceId);

            // invoke the operation
            await subscriptionSecurityAlert.DismissAsync();

            Console.WriteLine($"Succeeded");
        }

        // Update security alert state on a subscription from a security data location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Resolve_UpdateSecurityAlertStateOnASubscriptionFromASecurityDataLocation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2022-01-01/examples/Alerts/UpdateAlertSubscriptionLocation_resolve_example.json
            // this example is just showing the usage of "Alerts_UpdateSubscriptionLevelStateToResolve" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSecurityAlertResource created on azure
            // for more information of creating SubscriptionSecurityAlertResource, please refer to the document of SubscriptionSecurityAlertResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            AzureLocation ascLocation = new AzureLocation("westeurope");
            string alertName = "2518298467986649999_4d25bfef-2d77-4a08-adc0-3e35715cc92a";
            ResourceIdentifier subscriptionSecurityAlertResourceId = SubscriptionSecurityAlertResource.CreateResourceIdentifier(subscriptionId, ascLocation, alertName);
            SubscriptionSecurityAlertResource subscriptionSecurityAlert = client.GetSubscriptionSecurityAlertResource(subscriptionSecurityAlertResourceId);

            // invoke the operation
            await subscriptionSecurityAlert.ResolveAsync();

            Console.WriteLine($"Succeeded");
        }

        // Update security alert state on a subscription from a security data location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Activate_UpdateSecurityAlertStateOnASubscriptionFromASecurityDataLocation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2022-01-01/examples/Alerts/UpdateAlertSubscriptionLocation_activate_example.json
            // this example is just showing the usage of "Alerts_UpdateSubscriptionLevelStateToActivate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSecurityAlertResource created on azure
            // for more information of creating SubscriptionSecurityAlertResource, please refer to the document of SubscriptionSecurityAlertResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            AzureLocation ascLocation = new AzureLocation("westeurope");
            string alertName = "2518298467986649999_4d25bfef-2d77-4a08-adc0-3e35715cc92a";
            ResourceIdentifier subscriptionSecurityAlertResourceId = SubscriptionSecurityAlertResource.CreateResourceIdentifier(subscriptionId, ascLocation, alertName);
            SubscriptionSecurityAlertResource subscriptionSecurityAlert = client.GetSubscriptionSecurityAlertResource(subscriptionSecurityAlertResourceId);

            // invoke the operation
            await subscriptionSecurityAlert.ActivateAsync();

            Console.WriteLine($"Succeeded");
        }

        // Update security alert state on a subscription from a security data location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateSatateToInProgress_UpdateSecurityAlertStateOnASubscriptionFromASecurityDataLocation()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2022-01-01/examples/Alerts/UpdateAlertSubscriptionLocation_inProgress_example.json
            // this example is just showing the usage of "Alerts_UpdateSubscriptionLevelStateToInProgress" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionSecurityAlertResource created on azure
            // for more information of creating SubscriptionSecurityAlertResource, please refer to the document of SubscriptionSecurityAlertResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            AzureLocation ascLocation = new AzureLocation("westeurope");
            string alertName = "2518298467986649999_4d25bfef-2d77-4a08-adc0-3e35715cc92a";
            ResourceIdentifier subscriptionSecurityAlertResourceId = SubscriptionSecurityAlertResource.CreateResourceIdentifier(subscriptionId, ascLocation, alertName);
            SubscriptionSecurityAlertResource subscriptionSecurityAlert = client.GetSubscriptionSecurityAlertResource(subscriptionSecurityAlertResourceId);

            // invoke the operation
            await subscriptionSecurityAlert.UpdateSatateToInProgressAsync();

            Console.WriteLine($"Succeeded");
        }
    }
}
