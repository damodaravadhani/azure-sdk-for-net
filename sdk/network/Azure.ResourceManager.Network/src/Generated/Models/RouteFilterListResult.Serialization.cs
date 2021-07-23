// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class RouteFilterListResult
    {
        internal static RouteFilterListResult DeserializeRouteFilterListResult(JsonElement element)
        {
            Optional<IReadOnlyList<RouteFilterData>> value = default;
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
                    List<RouteFilterData> array = new List<RouteFilterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteFilterData.DeserializeRouteFilterData(item));
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
            return new RouteFilterListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
