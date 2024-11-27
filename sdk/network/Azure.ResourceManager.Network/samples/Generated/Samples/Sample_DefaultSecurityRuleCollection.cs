// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_DefaultSecurityRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_DefaultSecurityRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/DefaultSecurityRuleGet.json
            // this example is just showing the usage of "DefaultSecurityRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityGroupResource created on azure
            // for more information of creating NetworkSecurityGroupResource, please refer to the document of NetworkSecurityGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkSecurityGroupName = "nsg1";
            ResourceIdentifier networkSecurityGroupResourceId = NetworkSecurityGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityGroupName);
            NetworkSecurityGroupResource networkSecurityGroup = client.GetNetworkSecurityGroupResource(networkSecurityGroupResourceId);

            // get the collection of this DefaultSecurityRuleResource
            DefaultSecurityRuleCollection collection = networkSecurityGroup.GetDefaultSecurityRules();

            // invoke the operation
            string defaultSecurityRuleName = "AllowVnetInBound";
            DefaultSecurityRuleResource result = await collection.GetAsync(defaultSecurityRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_DefaultSecurityRuleList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/DefaultSecurityRuleList.json
            // this example is just showing the usage of "DefaultSecurityRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityGroupResource created on azure
            // for more information of creating NetworkSecurityGroupResource, please refer to the document of NetworkSecurityGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkSecurityGroupName = "nsg1";
            ResourceIdentifier networkSecurityGroupResourceId = NetworkSecurityGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityGroupName);
            NetworkSecurityGroupResource networkSecurityGroup = client.GetNetworkSecurityGroupResource(networkSecurityGroupResourceId);

            // get the collection of this DefaultSecurityRuleResource
            DefaultSecurityRuleCollection collection = networkSecurityGroup.GetDefaultSecurityRules();

            // invoke the operation and iterate over the result
            await foreach (DefaultSecurityRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_DefaultSecurityRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/DefaultSecurityRuleGet.json
            // this example is just showing the usage of "DefaultSecurityRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityGroupResource created on azure
            // for more information of creating NetworkSecurityGroupResource, please refer to the document of NetworkSecurityGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkSecurityGroupName = "nsg1";
            ResourceIdentifier networkSecurityGroupResourceId = NetworkSecurityGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityGroupName);
            NetworkSecurityGroupResource networkSecurityGroup = client.GetNetworkSecurityGroupResource(networkSecurityGroupResourceId);

            // get the collection of this DefaultSecurityRuleResource
            DefaultSecurityRuleCollection collection = networkSecurityGroup.GetDefaultSecurityRules();

            // invoke the operation
            string defaultSecurityRuleName = "AllowVnetInBound";
            bool result = await collection.ExistsAsync(defaultSecurityRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_DefaultSecurityRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/DefaultSecurityRuleGet.json
            // this example is just showing the usage of "DefaultSecurityRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkSecurityGroupResource created on azure
            // for more information of creating NetworkSecurityGroupResource, please refer to the document of NetworkSecurityGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkSecurityGroupName = "nsg1";
            ResourceIdentifier networkSecurityGroupResourceId = NetworkSecurityGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkSecurityGroupName);
            NetworkSecurityGroupResource networkSecurityGroup = client.GetNetworkSecurityGroupResource(networkSecurityGroupResourceId);

            // get the collection of this DefaultSecurityRuleResource
            DefaultSecurityRuleCollection collection = networkSecurityGroup.GetDefaultSecurityRules();

            // invoke the operation
            string defaultSecurityRuleName = "AllowVnetInBound";
            NullableResponse<DefaultSecurityRuleResource> response = await collection.GetIfExistsAsync(defaultSecurityRuleName);
            DefaultSecurityRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
