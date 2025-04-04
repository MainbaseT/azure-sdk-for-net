// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    /// <summary></summary>
    public partial class ContentFilterBlocklistResult : IJsonModel<ContentFilterBlocklistResult>
    {
        internal ContentFilterBlocklistResult()
        {
        }

        void IJsonModel<ContentFilterBlocklistResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterBlocklistResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentFilterBlocklistResult)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("filtered") != true)
            {
                writer.WritePropertyName("filtered"u8);
                writer.WriteBooleanValue(Filtered);
            }
            if (Optional.IsCollectionDefined(InternalDetails) && _additionalBinaryDataProperties?.ContainsKey("details") != true)
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (InternalAzureContentFilterBlocklistResultDetail item in InternalDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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

        ContentFilterBlocklistResult IJsonModel<ContentFilterBlocklistResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ContentFilterBlocklistResult JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterBlocklistResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentFilterBlocklistResult)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentFilterBlocklistResult(document.RootElement, options);
        }

        internal static ContentFilterBlocklistResult DeserializeContentFilterBlocklistResult(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool filtered = default;
            IReadOnlyList<InternalAzureContentFilterBlocklistResultDetail> internalDetails = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("filtered"u8))
                {
                    filtered = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("details"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InternalAzureContentFilterBlocklistResultDetail> array = new List<InternalAzureContentFilterBlocklistResultDetail>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(InternalAzureContentFilterBlocklistResultDetail.DeserializeInternalAzureContentFilterBlocklistResultDetail(item, options));
                    }
                    internalDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new ContentFilterBlocklistResult(filtered, internalDetails ?? new ChangeTrackingList<InternalAzureContentFilterBlocklistResultDetail>(), additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ContentFilterBlocklistResult>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterBlocklistResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentFilterBlocklistResult)} does not support writing '{options.Format}' format.");
            }
        }

        ContentFilterBlocklistResult IPersistableModel<ContentFilterBlocklistResult>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual ContentFilterBlocklistResult PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ContentFilterBlocklistResult>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeContentFilterBlocklistResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentFilterBlocklistResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentFilterBlocklistResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="contentFilterBlocklistResult"> The <see cref="ContentFilterBlocklistResult"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(ContentFilterBlocklistResult contentFilterBlocklistResult)
        {
            if (contentFilterBlocklistResult == null)
            {
                return null;
            }
            return BinaryContent.Create(contentFilterBlocklistResult, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="ContentFilterBlocklistResult"/> from. </param>
        public static explicit operator ContentFilterBlocklistResult(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeContentFilterBlocklistResult(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
