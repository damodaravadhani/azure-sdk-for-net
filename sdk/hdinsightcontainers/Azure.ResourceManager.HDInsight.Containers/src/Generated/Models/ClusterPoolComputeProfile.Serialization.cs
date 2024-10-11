// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterPoolComputeProfile : IUtf8JsonSerializable, IJsonModel<ClusterPoolComputeProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterPoolComputeProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterPoolComputeProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolComputeProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolComputeProfile)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("vmSize"u8);
            writer.WriteStringValue(VmSize);
            if (options.Format != "W" && Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ClusterPoolComputeProfile IJsonModel<ClusterPoolComputeProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolComputeProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolComputeProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterPoolComputeProfile(document.RootElement, options);
        }

        internal static ClusterPoolComputeProfile DeserializeClusterPoolComputeProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vmSize = default;
            int? count = default;
            IList<string> availabilityZones = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("availabilityZones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    availabilityZones = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterPoolComputeProfile(vmSize, count, availabilityZones ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VmSize), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  vmSize: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VmSize))
                {
                    builder.Append("  vmSize: ");
                    if (VmSize.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{VmSize}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{VmSize}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Count), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  count: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Count))
                {
                    builder.Append("  count: ");
                    builder.AppendLine($"{Count.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AvailabilityZones), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  availabilityZones: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AvailabilityZones))
                {
                    if (AvailabilityZones.Any())
                    {
                        builder.Append("  availabilityZones: ");
                        builder.AppendLine("[");
                        foreach (var item in AvailabilityZones)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClusterPoolComputeProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolComputeProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolComputeProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterPoolComputeProfile IPersistableModel<ClusterPoolComputeProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolComputeProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterPoolComputeProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolComputeProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterPoolComputeProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
