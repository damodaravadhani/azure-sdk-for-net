// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayHttpListener : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(FrontendIPConfiguration))
            {
                writer.WritePropertyName("frontendIPConfiguration");
                writer.WriteObjectValue(FrontendIPConfiguration);
            }
            if (Optional.IsDefined(FrontendPort))
            {
                writer.WritePropertyName("frontendPort");
                writer.WriteObjectValue(FrontendPort);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(SslCertificate))
            {
                writer.WritePropertyName("sslCertificate");
                writer.WriteObjectValue(SslCertificate);
            }
            if (Optional.IsDefined(SslProfile))
            {
                writer.WritePropertyName("sslProfile");
                writer.WriteObjectValue(SslProfile);
            }
            if (Optional.IsDefined(RequireServerNameIndication))
            {
                writer.WritePropertyName("requireServerNameIndication");
                writer.WriteBooleanValue(RequireServerNameIndication.Value);
            }
            if (Optional.IsCollectionDefined(CustomErrorConfigurations))
            {
                writer.WritePropertyName("customErrorConfigurations");
                writer.WriteStartArray();
                foreach (var item in CustomErrorConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirewallPolicy))
            {
                writer.WritePropertyName("firewallPolicy");
                writer.WriteObjectValue(FirewallPolicy);
            }
            if (Optional.IsCollectionDefined(HostNames))
            {
                writer.WritePropertyName("hostNames");
                writer.WriteStartArray();
                foreach (var item in HostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayHttpListener DeserializeApplicationGatewayHttpListener(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            ResourceIdentifier id = default;
            Optional<SubResource> frontendIPConfiguration = default;
            Optional<SubResource> frontendPort = default;
            Optional<ApplicationGatewayProtocol> protocol = default;
            Optional<string> hostName = default;
            Optional<SubResource> sslCertificate = default;
            Optional<SubResource> sslProfile = default;
            Optional<bool> requireServerNameIndication = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<IList<ApplicationGatewayCustomError>> customErrorConfigurations = default;
            Optional<SubResource> firewallPolicy = default;
            Optional<IList<string>> hostNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("frontendIPConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            frontendIPConfiguration = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("frontendPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            frontendPort = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            protocol = new ApplicationGatewayProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sslCertificate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sslCertificate = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sslProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sslProfile = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("requireServerNameIndication"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requireServerNameIndication = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customErrorConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationGatewayCustomError> array = new List<ApplicationGatewayCustomError>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationGatewayCustomError.DeserializeApplicationGatewayCustomError(item));
                            }
                            customErrorConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            firewallPolicy = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            hostNames = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayHttpListener(id, name.Value, etag.Value, type.Value, frontendIPConfiguration.Value, frontendPort.Value, Optional.ToNullable(protocol), hostName.Value, sslCertificate.Value, sslProfile.Value, Optional.ToNullable(requireServerNameIndication), Optional.ToNullable(provisioningState), Optional.ToList(customErrorConfigurations), firewallPolicy.Value, Optional.ToList(hostNames));
        }
    }
}
