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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automanage.Models
{
    public partial class ConfigurationProfileAssignmentReportResourceDetails : IUtf8JsonSerializable, IJsonModel<ConfigurationProfileAssignmentReportResourceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationProfileAssignmentReportResourceDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConfigurationProfileAssignmentReportResourceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationProfileAssignmentReportResourceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationProfileAssignmentReportResourceDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                ((IJsonModel<ResponseError>)Error).Write(writer, options);
            }
        }

        ConfigurationProfileAssignmentReportResourceDetails IJsonModel<ConfigurationProfileAssignmentReportResourceDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationProfileAssignmentReportResourceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationProfileAssignmentReportResourceDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationProfileAssignmentReportResourceDetails(document.RootElement, options);
        }

        internal static ConfigurationProfileAssignmentReportResourceDetails DeserializeConfigurationProfileAssignmentReportResourceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string status = default;
            ResponseError error = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ModelReaderWriter.Read<ResponseError>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerAutomanageContext.Default);
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerAutomanageContext.Default);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConfigurationProfileAssignmentReportResourceDetails(
                id,
                name,
                type,
                systemData,
                status,
                error,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfigurationProfileAssignmentReportResourceDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationProfileAssignmentReportResourceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAutomanageContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationProfileAssignmentReportResourceDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ConfigurationProfileAssignmentReportResourceDetails IPersistableModel<ConfigurationProfileAssignmentReportResourceDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationProfileAssignmentReportResourceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConfigurationProfileAssignmentReportResourceDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationProfileAssignmentReportResourceDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationProfileAssignmentReportResourceDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
