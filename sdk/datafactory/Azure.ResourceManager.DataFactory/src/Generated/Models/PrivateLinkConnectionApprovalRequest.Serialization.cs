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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PrivateLinkConnectionApprovalRequest : IUtf8JsonSerializable, IJsonModel<PrivateLinkConnectionApprovalRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateLinkConnectionApprovalRequest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateLinkConnectionApprovalRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkConnectionApprovalRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateLinkConnectionApprovalRequest)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PrivateLinkServiceConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                writer.WriteObjectValue(PrivateLinkServiceConnectionState, options);
            }
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                ((IJsonModel<WritableSubResource>)PrivateEndpoint).Write(writer, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        PrivateLinkConnectionApprovalRequest IJsonModel<PrivateLinkConnectionApprovalRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkConnectionApprovalRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateLinkConnectionApprovalRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateLinkConnectionApprovalRequest(document.RootElement, options);
        }

        internal static PrivateLinkConnectionApprovalRequest DeserializePrivateLinkConnectionApprovalRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PrivateLinkConnectionState privateLinkServiceConnectionState = default;
            WritableSubResource privateEndpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceConnectionState = PrivateLinkConnectionState.DeserializePrivateLinkConnectionState(property.Value, options);
                    continue;
                }
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = ModelReaderWriter.Read<WritableSubResource>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), options, AzureResourceManagerDataFactoryContext.Default);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PrivateLinkConnectionApprovalRequest(privateLinkServiceConnectionState, privateEndpoint, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateLinkConnectionApprovalRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkConnectionApprovalRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataFactoryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PrivateLinkConnectionApprovalRequest)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateLinkConnectionApprovalRequest IPersistableModel<PrivateLinkConnectionApprovalRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateLinkConnectionApprovalRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePrivateLinkConnectionApprovalRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateLinkConnectionApprovalRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateLinkConnectionApprovalRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
