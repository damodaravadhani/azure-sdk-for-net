﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Provisioning.Authorization;
using Azure.Provisioning.CloudMachine;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.ServiceBus;

namespace Azure.CloudMachine;

public class ServiceBusNamespaceFeature(string name, ServiceBusSkuName sku = ServiceBusSkuName.Standard, ServiceBusSkuTier tier = ServiceBusSkuTier.Standard) : CloudMachineFeature
{
    protected override ProvisionableResource EmitCore(CloudMachineInfrastructure infrastructure)
    {
        var _serviceBusNamespace = new ServiceBusNamespace("cm_servicebus")
        {
            Sku = new ServiceBusSku
            {
                Name = sku,
                Tier = tier
            },
            Name = name,
        };
        infrastructure.AddResource(_serviceBusNamespace);
        infrastructure.AddResource(
            new ServiceBusNamespaceAuthorizationRule("cm_servicebus_auth_rule", "2021-11-01")
            {
                Parent = _serviceBusNamespace,
                Rights = [ServiceBusAccessRight.Listen, ServiceBusAccessRight.Send, ServiceBusAccessRight.Manage]
            }
        );

        RequiredSystemRoles.Add(
            _serviceBusNamespace,
            [
                (ServiceBusBuiltInRole.GetBuiltInRoleName(ServiceBusBuiltInRole.AzureServiceBusDataOwner), ServiceBusBuiltInRole.AzureServiceBusDataOwner.ToString()),
            ]);

        Emitted = _serviceBusNamespace;
        return _serviceBusNamespace;
    }
}
