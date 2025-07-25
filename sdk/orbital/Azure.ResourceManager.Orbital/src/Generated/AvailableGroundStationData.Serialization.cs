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
using Azure.ResourceManager.Orbital.Models;

namespace Azure.ResourceManager.Orbital
{
    public partial class AvailableGroundStationData : IUtf8JsonSerializable, IJsonModel<AvailableGroundStationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailableGroundStationData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvailableGroundStationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableGroundStationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableGroundStationData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(City))
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (Optional.IsDefined(ProviderName))
            {
                writer.WritePropertyName("providerName"u8);
                writer.WriteStringValue(ProviderName);
            }
            if (Optional.IsDefined(LongitudeDegrees))
            {
                writer.WritePropertyName("longitudeDegrees"u8);
                writer.WriteNumberValue(LongitudeDegrees.Value);
            }
            if (Optional.IsDefined(LatitudeDegrees))
            {
                writer.WritePropertyName("latitudeDegrees"u8);
                writer.WriteNumberValue(LatitudeDegrees.Value);
            }
            if (Optional.IsDefined(AltitudeMeters))
            {
                writer.WritePropertyName("altitudeMeters"u8);
                writer.WriteNumberValue(AltitudeMeters.Value);
            }
            if (Optional.IsDefined(ReleaseMode))
            {
                writer.WritePropertyName("releaseMode"u8);
                writer.WriteStringValue(ReleaseMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        AvailableGroundStationData IJsonModel<AvailableGroundStationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableGroundStationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableGroundStationData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableGroundStationData(document.RootElement, options);
        }

        internal static AvailableGroundStationData DeserializeAvailableGroundStationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string city = default;
            string providerName = default;
            float? longitudeDegrees = default;
            float? latitudeDegrees = default;
            float? altitudeMeters = default;
            GroundStationReleaseMode? releaseMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerOrbitalContext.Default);
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
                        if (property0.NameEquals("city"u8))
                        {
                            city = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("providerName"u8))
                        {
                            providerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("longitudeDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            longitudeDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("latitudeDegrees"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            latitudeDegrees = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("altitudeMeters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            altitudeMeters = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("releaseMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            releaseMode = new GroundStationReleaseMode(property0.Value.GetString());
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
            return new AvailableGroundStationData(
                id,
                name,
                type,
                systemData,
                location,
                city,
                providerName,
                longitudeDegrees,
                latitudeDegrees,
                altitudeMeters,
                releaseMode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailableGroundStationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableGroundStationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerOrbitalContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AvailableGroundStationData)} does not support writing '{options.Format}' format.");
            }
        }

        AvailableGroundStationData IPersistableModel<AvailableGroundStationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableGroundStationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAvailableGroundStationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailableGroundStationData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailableGroundStationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
