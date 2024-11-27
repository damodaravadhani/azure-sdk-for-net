// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventHubs.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.EventHubs.Samples
{
    public partial class Sample_EventHubCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_EventHubCreate()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubCreate.json
            // this example is just showing the usage of "EventHubs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "Default-NotificationHubs-AustraliaEast";
            string namespaceName = "sdk-Namespace-5357";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // get the collection of this EventHubResource
            EventHubCollection collection = eventHubsNamespace.GetEventHubs();

            // invoke the operation
            string eventHubName = "sdk-EventHub-6547";
            EventHubData data = new EventHubData
            {
                PartitionCount = 4L,
                Status = EventHubEntityStatus.Active,
                UserMetadata = "key",
                CaptureDescription = new CaptureDescription
                {
                    Enabled = true,
                    Encoding = EncodingCaptureDescription.Avro,
                    IntervalInSeconds = 120,
                    SizeLimitInBytes = 10485763,
                    Destination = new EventHubDestination
                    {
                        Name = "EventHubArchive.AzureBlockBlob",
                        Identity = new EventHubsCaptureIdentity
                        {
                            IdentityType = EventHubsCaptureIdentityType.UserAssigned,
                            UserAssignedIdentity = "/subscriptions/SampleSubscription/resourceGroups/ResurceGroupSample/providers/Microsoft.ManagedIdentity/userAssignedIdentities/ud2",
                        },
                        StorageAccountResourceId = new ResourceIdentifier("/subscriptions/e2f361f0-3b27-4503-a9cc-21cfba380093/resourceGroups/Default-Storage-SouthCentralUS/providers/Microsoft.ClassicStorage/storageAccounts/arjunteststorage"),
                        BlobContainer = "container",
                        ArchiveNameFormat = "{Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}",
                    },
                },
                RetentionDescription = new RetentionDescription
                {
                    CleanupPolicy = CleanupPolicyRetentionDescription.Compaction,
                    RetentionTimeInHours = 96L,
                    TombstoneRetentionTimeInHours = 1,
                },
            };
            ArmOperation<EventHubResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, eventHubName, data);
            EventHubResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_EventHubGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubGet.json
            // this example is just showing the usage of "EventHubs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "e2f361f0-3b27-4503-a9cc-21cfba380093";
            string resourceGroupName = "Default-NotificationHubs-AustraliaEast";
            string namespaceName = "sdk-Namespace-716";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // get the collection of this EventHubResource
            EventHubCollection collection = eventHubsNamespace.GetEventHubs();

            // invoke the operation
            string eventHubName = "sdk-EventHub-10";
            EventHubResource result = await collection.GetAsync(eventHubName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_EventHubsListAll()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubListByNameSpace.json
            // this example is just showing the usage of "EventHubs_ListByNamespace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "e2f361f0-3b27-4503-a9cc-21cfba380093";
            string resourceGroupName = "Default-NotificationHubs-AustraliaEast";
            string namespaceName = "sdk-Namespace-5357";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // get the collection of this EventHubResource
            EventHubCollection collection = eventHubsNamespace.GetEventHubs();

            // invoke the operation and iterate over the result
            await foreach (EventHubResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventHubData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_EventHubGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubGet.json
            // this example is just showing the usage of "EventHubs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "e2f361f0-3b27-4503-a9cc-21cfba380093";
            string resourceGroupName = "Default-NotificationHubs-AustraliaEast";
            string namespaceName = "sdk-Namespace-716";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // get the collection of this EventHubResource
            EventHubCollection collection = eventHubsNamespace.GetEventHubs();

            // invoke the operation
            string eventHubName = "sdk-EventHub-10";
            bool result = await collection.ExistsAsync(eventHubName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_EventHubGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/stable/2024-01-01/examples/EventHubs/EHEventHubGet.json
            // this example is just showing the usage of "EventHubs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubsNamespaceResource created on azure
            // for more information of creating EventHubsNamespaceResource, please refer to the document of EventHubsNamespaceResource
            string subscriptionId = "e2f361f0-3b27-4503-a9cc-21cfba380093";
            string resourceGroupName = "Default-NotificationHubs-AustraliaEast";
            string namespaceName = "sdk-Namespace-716";
            ResourceIdentifier eventHubsNamespaceResourceId = EventHubsNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventHubsNamespaceResource eventHubsNamespace = client.GetEventHubsNamespaceResource(eventHubsNamespaceResourceId);

            // get the collection of this EventHubResource
            EventHubCollection collection = eventHubsNamespace.GetEventHubs();

            // invoke the operation
            string eventHubName = "sdk-EventHub-10";
            NullableResponse<EventHubResource> response = await collection.GetIfExistsAsync(eventHubName);
            EventHubResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventHubData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
