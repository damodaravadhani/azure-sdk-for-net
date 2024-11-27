// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Automation.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_SoftwareUpdateConfigurationResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetSoftwareUpdateConfigurationByName()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2019-06-01/examples/softwareUpdateConfiguration/getSoftwareUpdateConfigurationByName.json
            // this example is just showing the usage of "SoftwareUpdateConfigurations_GetByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SoftwareUpdateConfigurationResource created on azure
            // for more information of creating SoftwareUpdateConfigurationResource, please refer to the document of SoftwareUpdateConfigurationResource
            string subscriptionId = "51766542-3ed7-4a72-a187-0c8ab644ddab";
            string resourceGroupName = "mygroup";
            string automationAccountName = "myaccount";
            string softwareUpdateConfigurationName = "mypatch";
            ResourceIdentifier softwareUpdateConfigurationResourceId = SoftwareUpdateConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, softwareUpdateConfigurationName);
            SoftwareUpdateConfigurationResource softwareUpdateConfiguration = client.GetSoftwareUpdateConfigurationResource(softwareUpdateConfigurationResourceId);

            // invoke the operation
            SoftwareUpdateConfigurationResource result = await softwareUpdateConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SoftwareUpdateConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteSoftwareUpdateConfiguration()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2019-06-01/examples/softwareUpdateConfiguration/deleteSoftwareUpdateConfiguration.json
            // this example is just showing the usage of "SoftwareUpdateConfigurations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SoftwareUpdateConfigurationResource created on azure
            // for more information of creating SoftwareUpdateConfigurationResource, please refer to the document of SoftwareUpdateConfigurationResource
            string subscriptionId = "51766542-3ed7-4a72-a187-0c8ab644ddab";
            string resourceGroupName = "mygroup";
            string automationAccountName = "myaccount";
            string softwareUpdateConfigurationName = "mypatch";
            ResourceIdentifier softwareUpdateConfigurationResourceId = SoftwareUpdateConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, softwareUpdateConfigurationName);
            SoftwareUpdateConfigurationResource softwareUpdateConfiguration = client.GetSoftwareUpdateConfigurationResource(softwareUpdateConfigurationResourceId);

            // invoke the operation
            await softwareUpdateConfiguration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_CreateSoftwareUpdateConfiguration()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2019-06-01/examples/softwareUpdateConfiguration/createSoftwareUpdateConfiguration.json
            // this example is just showing the usage of "SoftwareUpdateConfigurations_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SoftwareUpdateConfigurationResource created on azure
            // for more information of creating SoftwareUpdateConfigurationResource, please refer to the document of SoftwareUpdateConfigurationResource
            string subscriptionId = "51766542-3ed7-4a72-a187-0c8ab644ddab";
            string resourceGroupName = "mygroup";
            string automationAccountName = "myaccount";
            string softwareUpdateConfigurationName = "testpatch";
            ResourceIdentifier softwareUpdateConfigurationResourceId = SoftwareUpdateConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, softwareUpdateConfigurationName);
            SoftwareUpdateConfigurationResource softwareUpdateConfiguration = client.GetSoftwareUpdateConfigurationResource(softwareUpdateConfigurationResourceId);

            // invoke the operation
            SoftwareUpdateConfigurationData data = new SoftwareUpdateConfigurationData(new SoftwareUpdateConfigurationSpecificProperties(SoftwareUpdateConfigurationOperatingSystemType.Windows)
            {
                Windows = new WindowsUpdateConfigurationProperties
                {
                    IncludedUpdateClassifications = WindowsUpdateClassification.Critical,
                    ExcludedKBNumbers = { "168934", "168973" },
                    RebootSetting = "IfRequired",
                },
                Duration = XmlConvert.ToTimeSpan("PT2H0M"),
                AzureVirtualMachines = { "/subscriptions/5ae68d89-69a4-454f-b5ce-e443cc4e0067/resourceGroups/myresources/providers/Microsoft.Compute/virtualMachines/vm-01", "/subscriptions/5ae68d89-69a4-454f-b5ce-e443cc4e0067/resourceGroups/myresources/providers/Microsoft.Compute/virtualMachines/vm-02", "/subscriptions/5ae68d89-69a4-454f-b5ce-e443cc4e0067/resourceGroups/myresources/providers/Microsoft.Compute/virtualMachines/vm-03" },
                NonAzureComputerNames = { "box1.contoso.com", "box2.contoso.com" },
                Targets = new SoftwareUpdateConfigurationTargetProperties
                {
                    AzureQueries = {new AzureQueryProperties
{
Scope = {"/subscriptions/5ae68d89-69a4-454f-b5ce-e443cc4e0067/resourceGroups/myresources", "/subscriptions/5ae68d89-69a4-454f-b5ce-e443cc4e0067"},
Locations = {new AzureLocation("Japan East"), new AzureLocation("UK South")},
TagSettings = new QueryTagSettingsProperties
{
Tags =
{
["tag1"] = {"tag1Value1", "tag1Value2", "tag1Value3"},
["tag2"] = {"tag2Value1", "tag2Value2", "tag2Value3"}
},
FilterOperator = QueryTagOperator.All,
},
}},
                    NonAzureQueries = {new NonAzureQueryProperties
{
FunctionAlias = "SavedSearch1",
WorkspaceId = "WorkspaceId1",
}, new NonAzureQueryProperties
{
FunctionAlias = "SavedSearch2",
WorkspaceId = "WorkspaceId2",
}},
                },
            }, new SoftwareUpdateConfigurationScheduleProperties
            {
                StartOn = DateTimeOffset.Parse("2017-10-19T12:22:57+00:00"),
                ExpireOn = DateTimeOffset.Parse("2018-11-09T11:22:57+00:00"),
                Interval = 1L,
                Frequency = AutomationScheduleFrequency.Hour,
                TimeZone = "America/Los_Angeles",
                AdvancedSchedule = new AutomationAdvancedSchedule
                {
                    WeekDays = { "Monday", "Thursday" },
                },
            })
            {
                Tasks = new SoftwareUpdateConfigurationTasks
                {
                    PreTask = new SoftwareUpdateConfigurationTaskProperties
                    {
                        Parameters =
{
["COMPUTERNAME"] = "Computer1"
},
                        Source = "HelloWorld",
                    },
                    PostTask = new SoftwareUpdateConfigurationTaskProperties
                    {
                        Parameters = { },
                        Source = "GetCache",
                    },
                },
            };
            ArmOperation<SoftwareUpdateConfigurationResource> lro = await softwareUpdateConfiguration.UpdateAsync(WaitUntil.Completed, data);
            SoftwareUpdateConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SoftwareUpdateConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
