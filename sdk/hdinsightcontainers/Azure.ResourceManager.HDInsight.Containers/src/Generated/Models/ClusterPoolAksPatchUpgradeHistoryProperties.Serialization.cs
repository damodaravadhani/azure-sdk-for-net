// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterPoolAksPatchUpgradeHistoryProperties : IUtf8JsonSerializable, IJsonModel<ClusterPoolAksPatchUpgradeHistoryProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterPoolAksPatchUpgradeHistoryProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterPoolAksPatchUpgradeHistoryProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAksPatchUpgradeHistoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolAksPatchUpgradeHistoryProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(UpgradeClusterPool))
            {
                writer.WritePropertyName("upgradeClusterPool"u8);
                writer.WriteBooleanValue(UpgradeClusterPool.Value);
            }
            if (Optional.IsDefined(UpgradeAllClusterNodes))
            {
                writer.WritePropertyName("upgradeAllClusterNodes"u8);
                writer.WriteBooleanValue(UpgradeAllClusterNodes.Value);
            }
            if (Optional.IsDefined(OriginalVersion))
            {
                writer.WritePropertyName("originalVersion"u8);
                writer.WriteStringValue(OriginalVersion);
            }
            if (Optional.IsDefined(NewVersion))
            {
                writer.WritePropertyName("newVersion"u8);
                writer.WriteStringValue(NewVersion);
            }
        }

        ClusterPoolAksPatchUpgradeHistoryProperties IJsonModel<ClusterPoolAksPatchUpgradeHistoryProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAksPatchUpgradeHistoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolAksPatchUpgradeHistoryProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterPoolAksPatchUpgradeHistoryProperties(document.RootElement, options);
        }

        internal static ClusterPoolAksPatchUpgradeHistoryProperties DeserializeClusterPoolAksPatchUpgradeHistoryProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? upgradeClusterPool = default;
            bool? upgradeAllClusterNodes = default;
            string originalVersion = default;
            string newVersion = default;
            ClusterPoolUpgradeHistoryType upgradeType = default;
            string utcTime = default;
            ClusterPoolUpgradeHistoryUpgradeResultType upgradeResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("upgradeClusterPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeClusterPool = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("upgradeAllClusterNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeAllClusterNodes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("originalVersion"u8))
                {
                    originalVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("newVersion"u8))
                {
                    newVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeType"u8))
                {
                    upgradeType = new ClusterPoolUpgradeHistoryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("utcTime"u8))
                {
                    utcTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeResult"u8))
                {
                    upgradeResult = new ClusterPoolUpgradeHistoryUpgradeResultType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterPoolAksPatchUpgradeHistoryProperties(
                upgradeType,
                utcTime,
                upgradeResult,
                serializedAdditionalRawData,
                upgradeClusterPool,
                upgradeAllClusterNodes,
                originalVersion,
                newVersion);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpgradeClusterPool), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  upgradeClusterPool: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UpgradeClusterPool))
                {
                    builder.Append("  upgradeClusterPool: ");
                    var boolValue = UpgradeClusterPool.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpgradeAllClusterNodes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  upgradeAllClusterNodes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UpgradeAllClusterNodes))
                {
                    builder.Append("  upgradeAllClusterNodes: ");
                    var boolValue = UpgradeAllClusterNodes.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OriginalVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  originalVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OriginalVersion))
                {
                    builder.Append("  originalVersion: ");
                    if (OriginalVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{OriginalVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{OriginalVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NewVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  newVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NewVersion))
                {
                    builder.Append("  newVersion: ");
                    if (NewVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NewVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NewVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpgradeType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  upgradeType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  upgradeType: ");
                builder.AppendLine($"'{UpgradeType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UtcTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  utcTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UtcTime))
                {
                    builder.Append("  utcTime: ");
                    if (UtcTime.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UtcTime}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UtcTime}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpgradeResult), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  upgradeResult: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  upgradeResult: ");
                builder.AppendLine($"'{UpgradeResult.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClusterPoolAksPatchUpgradeHistoryProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAksPatchUpgradeHistoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolAksPatchUpgradeHistoryProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterPoolAksPatchUpgradeHistoryProperties IPersistableModel<ClusterPoolAksPatchUpgradeHistoryProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolAksPatchUpgradeHistoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterPoolAksPatchUpgradeHistoryProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolAksPatchUpgradeHistoryProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterPoolAksPatchUpgradeHistoryProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
