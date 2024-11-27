// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Support.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_TenantResourceExtensions
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CheckNameAvailabilitySupportTicketsNoSubscription_ChecksWhetherNameIsAvailableForSupportTicketResource()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/stable/2024-04-01/examples/CheckNameAvailability.json
            // this example is just showing the usage of "SupportTicketsNoSubscription_CheckNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            TenantResource tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation
            SupportNameAvailabilityContent content = new SupportNameAvailabilityContent("sampleName", SupportResourceType.MicrosoftSupportSupportTickets);
            SupportNameAvailabilityResult result = await tenantResource.CheckNameAvailabilitySupportTicketsNoSubscriptionAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
