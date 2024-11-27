// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Storage.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Storage.Samples
{
    public partial class Sample_ObjectReplicationPolicyResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_StorageAccountGetObjectReplicationPolicies()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountGetObjectReplicationPolicy.json
            // this example is just showing the usage of "ObjectReplicationPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ObjectReplicationPolicyResource created on azure
            // for more information of creating ObjectReplicationPolicyResource, please refer to the document of ObjectReplicationPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            string objectReplicationPolicyId = "{objectReplicationPolicy-Id}";
            ResourceIdentifier objectReplicationPolicyResourceId = ObjectReplicationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, objectReplicationPolicyId);
            ObjectReplicationPolicyResource objectReplicationPolicy = client.GetObjectReplicationPolicyResource(objectReplicationPolicyResourceId);

            // invoke the operation
            ObjectReplicationPolicyResource result = await objectReplicationPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ObjectReplicationPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_StorageAccountDeleteObjectReplicationPolicies()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountDeleteObjectReplicationPolicy.json
            // this example is just showing the usage of "ObjectReplicationPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ObjectReplicationPolicyResource created on azure
            // for more information of creating ObjectReplicationPolicyResource, please refer to the document of ObjectReplicationPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res6977";
            string accountName = "sto2527";
            string objectReplicationPolicyId = "{objectReplicationPolicy-Id}";
            ResourceIdentifier objectReplicationPolicyResourceId = ObjectReplicationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, objectReplicationPolicyId);
            ObjectReplicationPolicyResource objectReplicationPolicy = client.GetObjectReplicationPolicyResource(objectReplicationPolicyResourceId);

            // invoke the operation
            await objectReplicationPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_StorageAccountCreateObjectReplicationPolicyOnDestination()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountCreateObjectReplicationPolicyOnDestination.json
            // this example is just showing the usage of "ObjectReplicationPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ObjectReplicationPolicyResource created on azure
            // for more information of creating ObjectReplicationPolicyResource, please refer to the document of ObjectReplicationPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "dst112";
            string objectReplicationPolicyId = "default";
            ResourceIdentifier objectReplicationPolicyResourceId = ObjectReplicationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, objectReplicationPolicyId);
            ObjectReplicationPolicyResource objectReplicationPolicy = client.GetObjectReplicationPolicyResource(objectReplicationPolicyResourceId);

            // invoke the operation
            ObjectReplicationPolicyData data = new ObjectReplicationPolicyData
            {
                SourceAccount = "src1122",
                DestinationAccount = "dst112",
                Rules = {new ObjectReplicationPolicyRule("scont139", "dcont139")
{
Filters = new ObjectReplicationPolicyFilter
{
PrefixMatch = {"blobA", "blobB"},
},
}},
            };
            ArmOperation<ObjectReplicationPolicyResource> lro = await objectReplicationPolicy.UpdateAsync(WaitUntil.Completed, data);
            ObjectReplicationPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ObjectReplicationPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_StorageAccountCreateObjectReplicationPolicyOnSource()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountCreateObjectReplicationPolicyOnSource.json
            // this example is just showing the usage of "ObjectReplicationPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ObjectReplicationPolicyResource created on azure
            // for more information of creating ObjectReplicationPolicyResource, please refer to the document of ObjectReplicationPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "src1122";
            string objectReplicationPolicyId = "2a20bb73-5717-4635-985a-5d4cf777438f";
            ResourceIdentifier objectReplicationPolicyResourceId = ObjectReplicationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, objectReplicationPolicyId);
            ObjectReplicationPolicyResource objectReplicationPolicy = client.GetObjectReplicationPolicyResource(objectReplicationPolicyResourceId);

            // invoke the operation
            ObjectReplicationPolicyData data = new ObjectReplicationPolicyData
            {
                SourceAccount = "src1122",
                DestinationAccount = "dst112",
                Rules = {new ObjectReplicationPolicyRule("scont139", "dcont139")
{
RuleId = "d5d18a48-8801-4554-aeaa-74faf65f5ef9",
Filters = new ObjectReplicationPolicyFilter
{
PrefixMatch = {"blobA", "blobB"},
MinCreationTime = "2020-02-19T16:05:00Z",
},
}},
            };
            ArmOperation<ObjectReplicationPolicyResource> lro = await objectReplicationPolicy.UpdateAsync(WaitUntil.Completed, data);
            ObjectReplicationPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ObjectReplicationPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_StorageAccountUpdateObjectReplicationPolicyOnDestination()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountUpdateObjectReplicationPolicyOnDestination.json
            // this example is just showing the usage of "ObjectReplicationPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ObjectReplicationPolicyResource created on azure
            // for more information of creating ObjectReplicationPolicyResource, please refer to the document of ObjectReplicationPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "dst112";
            string objectReplicationPolicyId = "2a20bb73-5717-4635-985a-5d4cf777438f";
            ResourceIdentifier objectReplicationPolicyResourceId = ObjectReplicationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, objectReplicationPolicyId);
            ObjectReplicationPolicyResource objectReplicationPolicy = client.GetObjectReplicationPolicyResource(objectReplicationPolicyResourceId);

            // invoke the operation
            ObjectReplicationPolicyData data = new ObjectReplicationPolicyData
            {
                SourceAccount = "src1122",
                DestinationAccount = "dst112",
                Rules = {new ObjectReplicationPolicyRule("scont139", "dcont139")
{
RuleId = "d5d18a48-8801-4554-aeaa-74faf65f5ef9",
Filters = new ObjectReplicationPolicyFilter
{
PrefixMatch = {"blobA", "blobB"},
},
}, new ObjectReplicationPolicyRule("scont179", "dcont179")},
            };
            ArmOperation<ObjectReplicationPolicyResource> lro = await objectReplicationPolicy.UpdateAsync(WaitUntil.Completed, data);
            ObjectReplicationPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ObjectReplicationPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_StorageAccountUpdateObjectReplicationPolicyOnSource()
        {
            // Generated from example definition: specification/storage/resource-manager/Microsoft.Storage/stable/2023-05-01/examples/StorageAccountUpdateObjectReplicationPolicyOnSource.json
            // this example is just showing the usage of "ObjectReplicationPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ObjectReplicationPolicyResource created on azure
            // for more information of creating ObjectReplicationPolicyResource, please refer to the document of ObjectReplicationPolicyResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "res7687";
            string accountName = "src1122";
            string objectReplicationPolicyId = "2a20bb73-5717-4635-985a-5d4cf777438f";
            ResourceIdentifier objectReplicationPolicyResourceId = ObjectReplicationPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, objectReplicationPolicyId);
            ObjectReplicationPolicyResource objectReplicationPolicy = client.GetObjectReplicationPolicyResource(objectReplicationPolicyResourceId);

            // invoke the operation
            ObjectReplicationPolicyData data = new ObjectReplicationPolicyData
            {
                SourceAccount = "src1122",
                DestinationAccount = "dst112",
                Rules = {new ObjectReplicationPolicyRule("scont139", "dcont139")
{
RuleId = "d5d18a48-8801-4554-aeaa-74faf65f5ef9",
Filters = new ObjectReplicationPolicyFilter
{
PrefixMatch = {"blobA", "blobB"},
},
}, new ObjectReplicationPolicyRule("scont179", "dcont179")
{
RuleId = "cfbb4bc2-8b60-429f-b05a-d1e0942b33b2",
}},
            };
            ArmOperation<ObjectReplicationPolicyResource> lro = await objectReplicationPolicy.UpdateAsync(WaitUntil.Completed, data);
            ObjectReplicationPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ObjectReplicationPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
