// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ListHubRouteTablesResult
    {
        internal static ListHubRouteTablesResult DeserializeListHubRouteTablesResult(JsonElement element)
        {
            Optional<IReadOnlyList<HubRouteTableData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HubRouteTableData> array = new List<HubRouteTableData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HubRouteTableData.DeserializeHubRouteTableData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ListHubRouteTablesResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
