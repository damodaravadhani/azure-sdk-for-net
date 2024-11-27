// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceRegistry.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.DeviceRegistry.Samples
{
    public partial class Sample_DeviceRegistryAssetEndpointProfileResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnAssetEndpointProfile()
        {
            // Generated from example definition: specification/deviceregistry/resource-manager/Microsoft.DeviceRegistry/preview/2023-11-01-preview/examples/Get_AssetEndpointProfile.json
            // this example is just showing the usage of "AssetEndpointProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistryAssetEndpointProfileResource created on azure
            // for more information of creating DeviceRegistryAssetEndpointProfileResource, please refer to the document of DeviceRegistryAssetEndpointProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string assetEndpointProfileName = "my-assetendpointprofile";
            ResourceIdentifier deviceRegistryAssetEndpointProfileResourceId = DeviceRegistryAssetEndpointProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, assetEndpointProfileName);
            DeviceRegistryAssetEndpointProfileResource deviceRegistryAssetEndpointProfile = client.GetDeviceRegistryAssetEndpointProfileResource(deviceRegistryAssetEndpointProfileResourceId);

            // invoke the operation
            DeviceRegistryAssetEndpointProfileResource result = await deviceRegistryAssetEndpointProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistryAssetEndpointProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAnAssetEndpointProfile()
        {
            // Generated from example definition: specification/deviceregistry/resource-manager/Microsoft.DeviceRegistry/preview/2023-11-01-preview/examples/Delete_AssetEndpointProfile.json
            // this example is just showing the usage of "AssetEndpointProfiles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistryAssetEndpointProfileResource created on azure
            // for more information of creating DeviceRegistryAssetEndpointProfileResource, please refer to the document of DeviceRegistryAssetEndpointProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string assetEndpointProfileName = "my-assetendpointprofile";
            ResourceIdentifier deviceRegistryAssetEndpointProfileResourceId = DeviceRegistryAssetEndpointProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, assetEndpointProfileName);
            DeviceRegistryAssetEndpointProfileResource deviceRegistryAssetEndpointProfile = client.GetDeviceRegistryAssetEndpointProfileResource(deviceRegistryAssetEndpointProfileResourceId);

            // invoke the operation
            await deviceRegistryAssetEndpointProfile.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PatchAnAssetEndpointProfile()
        {
            // Generated from example definition: specification/deviceregistry/resource-manager/Microsoft.DeviceRegistry/preview/2023-11-01-preview/examples/Update_AssetEndpointProfile.json
            // this example is just showing the usage of "AssetEndpointProfiles_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceRegistryAssetEndpointProfileResource created on azure
            // for more information of creating DeviceRegistryAssetEndpointProfileResource, please refer to the document of DeviceRegistryAssetEndpointProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string assetEndpointProfileName = "my-assetendpointprofile";
            ResourceIdentifier deviceRegistryAssetEndpointProfileResourceId = DeviceRegistryAssetEndpointProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, assetEndpointProfileName);
            DeviceRegistryAssetEndpointProfileResource deviceRegistryAssetEndpointProfile = client.GetDeviceRegistryAssetEndpointProfileResource(deviceRegistryAssetEndpointProfileResourceId);

            // invoke the operation
            DeviceRegistryAssetEndpointProfilePatch patch = new DeviceRegistryAssetEndpointProfilePatch
            {
                TargetAddress = new Uri("https://www.example.com/myTargetAddress"),
            };
            ArmOperation<DeviceRegistryAssetEndpointProfileResource> lro = await deviceRegistryAssetEndpointProfile.UpdateAsync(WaitUntil.Completed, patch);
            DeviceRegistryAssetEndpointProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceRegistryAssetEndpointProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
