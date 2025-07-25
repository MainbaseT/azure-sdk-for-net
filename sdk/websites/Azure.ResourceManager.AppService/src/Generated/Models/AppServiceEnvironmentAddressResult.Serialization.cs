// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceEnvironmentAddressResult : IUtf8JsonSerializable, IJsonModel<AppServiceEnvironmentAddressResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceEnvironmentAddressResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppServiceEnvironmentAddressResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceEnvironmentAddressResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceEnvironmentAddressResult)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceIPAddress))
            {
                writer.WritePropertyName("serviceIpAddress"u8);
                writer.WriteStringValue(ServiceIPAddress.ToString());
            }
            if (Optional.IsDefined(InternalIPAddress))
            {
                writer.WritePropertyName("internalIpAddress"u8);
                writer.WriteStringValue(InternalIPAddress.ToString());
            }
            if (Optional.IsCollectionDefined(OutboundIPAddresses))
            {
                writer.WritePropertyName("outboundIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in OutboundIPAddresses)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualIPMappings))
            {
                writer.WritePropertyName("vipMappings"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualIPMappings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        AppServiceEnvironmentAddressResult IJsonModel<AppServiceEnvironmentAddressResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceEnvironmentAddressResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceEnvironmentAddressResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceEnvironmentAddressResult(document.RootElement, options);
        }

        internal static AppServiceEnvironmentAddressResult DeserializeAppServiceEnvironmentAddressResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IPAddress serviceIPAddress = default;
            IPAddress internalIPAddress = default;
            IList<IPAddress> outboundIPAddresses = default;
            IList<VirtualIPMapping> vipMappings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerAppServiceContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceIPAddress = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("internalIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internalIPAddress = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("outboundIpAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            outboundIPAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("vipMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualIPMapping> array = new List<VirtualIPMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualIPMapping.DeserializeVirtualIPMapping(item, options));
                            }
                            vipMappings = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppServiceEnvironmentAddressResult(
                id,
                name,
                type,
                systemData,
                serviceIPAddress,
                internalIPAddress,
                outboundIPAddresses ?? new ChangeTrackingList<IPAddress>(),
                vipMappings ?? new ChangeTrackingList<VirtualIPMapping>(),
                kind,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServiceIPAddress), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    serviceIpAddress: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServiceIPAddress))
                {
                    builder.Append("    serviceIpAddress: ");
                    builder.AppendLine($"'{ServiceIPAddress.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InternalIPAddress), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    internalIpAddress: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InternalIPAddress))
                {
                    builder.Append("    internalIpAddress: ");
                    builder.AppendLine($"'{InternalIPAddress.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OutboundIPAddresses), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    outboundIpAddresses: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(OutboundIPAddresses))
                {
                    if (OutboundIPAddresses.Any())
                    {
                        builder.Append("    outboundIpAddresses: ");
                        builder.AppendLine("[");
                        foreach (var item in OutboundIPAddresses)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"      '{item.ToString()}'");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VirtualIPMappings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    vipMappings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(VirtualIPMappings))
                {
                    if (VirtualIPMappings.Any())
                    {
                        builder.Append("    vipMappings: ");
                        builder.AppendLine("[");
                        foreach (var item in VirtualIPMappings)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    vipMappings: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AppServiceEnvironmentAddressResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceEnvironmentAddressResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceEnvironmentAddressResult)} does not support writing '{options.Format}' format.");
            }
        }

        AppServiceEnvironmentAddressResult IPersistableModel<AppServiceEnvironmentAddressResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceEnvironmentAddressResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppServiceEnvironmentAddressResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceEnvironmentAddressResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceEnvironmentAddressResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
