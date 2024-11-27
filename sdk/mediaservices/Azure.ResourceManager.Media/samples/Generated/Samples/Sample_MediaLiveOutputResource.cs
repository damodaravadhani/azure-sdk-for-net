// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_MediaLiveOutputResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetALiveOutputByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/liveoutput-list-by-name.json
            // this example is just showing the usage of "LiveOutputs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaLiveOutputResource created on azure
            // for more information of creating MediaLiveOutputResource, please refer to the document of MediaLiveOutputResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            string liveEventName = "myLiveEvent1";
            string liveOutputName = "myLiveOutput1";
            ResourceIdentifier mediaLiveOutputResourceId = MediaLiveOutputResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, liveEventName, liveOutputName);
            MediaLiveOutputResource mediaLiveOutput = client.GetMediaLiveOutputResource(mediaLiveOutputResourceId);

            // invoke the operation
            MediaLiveOutputResource result = await mediaLiveOutput.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaLiveOutputData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteALiveOutput()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/liveoutput-delete.json
            // this example is just showing the usage of "LiveOutputs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaLiveOutputResource created on azure
            // for more information of creating MediaLiveOutputResource, please refer to the document of MediaLiveOutputResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            string liveEventName = "myLiveEvent1";
            string liveOutputName = "myLiveOutput1";
            ResourceIdentifier mediaLiveOutputResourceId = MediaLiveOutputResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, liveEventName, liveOutputName);
            MediaLiveOutputResource mediaLiveOutput = client.GetMediaLiveOutputResource(mediaLiveOutputResourceId);

            // invoke the operation
            await mediaLiveOutput.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateALiveOutput()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Streaming/stable/2022-08-01/examples/liveoutput-create.json
            // this example is just showing the usage of "LiveOutputs_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaLiveOutputResource created on azure
            // for more information of creating MediaLiveOutputResource, please refer to the document of MediaLiveOutputResource
            string subscriptionId = "0a6ec948-5a62-437d-b9df-934dc7c1b722";
            string resourceGroupName = "mediaresources";
            string accountName = "slitestmedia10";
            string liveEventName = "myLiveEvent1";
            string liveOutputName = "myLiveOutput1";
            ResourceIdentifier mediaLiveOutputResourceId = MediaLiveOutputResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, liveEventName, liveOutputName);
            MediaLiveOutputResource mediaLiveOutput = client.GetMediaLiveOutputResource(mediaLiveOutputResourceId);

            // invoke the operation
            MediaLiveOutputData data = new MediaLiveOutputData
            {
                Description = "test live output 1",
                AssetName = "6f3264f5-a189-48b4-a29a-a40f22575212",
                ArchiveWindowLength = XmlConvert.ToTimeSpan("PT5M"),
                RewindWindowLength = XmlConvert.ToTimeSpan("PT4M"),
                ManifestName = "testmanifest",
                HlsFragmentsPerTsSegment = 5,
            };
            ArmOperation<MediaLiveOutputResource> lro = await mediaLiveOutput.UpdateAsync(WaitUntil.Completed, data);
            MediaLiveOutputResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaLiveOutputData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
