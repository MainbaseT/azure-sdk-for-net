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
using Azure.ResourceManager.VoiceServices.Models;

namespace Azure.ResourceManager.VoiceServices
{
    public partial class VoiceServicesCommunicationsGatewayData : IUtf8JsonSerializable, IJsonModel<VoiceServicesCommunicationsGatewayData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VoiceServicesCommunicationsGatewayData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VoiceServicesCommunicationsGatewayData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesCommunicationsGatewayData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VoiceServicesCommunicationsGatewayData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ServiceLocations))
            {
                writer.WritePropertyName("serviceLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLocations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Connectivity))
            {
                writer.WritePropertyName("connectivity"u8);
                writer.WriteStringValue(Connectivity.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Codecs))
            {
                writer.WritePropertyName("codecs"u8);
                writer.WriteStartArray();
                foreach (var item in Codecs)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(E911Type))
            {
                writer.WritePropertyName("e911Type"u8);
                writer.WriteStringValue(E911Type.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Platforms))
            {
                writer.WritePropertyName("platforms"u8);
                writer.WriteStartArray();
                foreach (var item in Platforms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ApiBridge))
            {
                writer.WritePropertyName("apiBridge"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ApiBridge);
#else
                using (JsonDocument document = JsonDocument.Parse(ApiBridge, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(AutoGeneratedDomainNameLabelScope))
            {
                writer.WritePropertyName("autoGeneratedDomainNameLabelScope"u8);
                writer.WriteStringValue(AutoGeneratedDomainNameLabelScope.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AutoGeneratedDomainNameLabel))
            {
                writer.WritePropertyName("autoGeneratedDomainNameLabel"u8);
                writer.WriteStringValue(AutoGeneratedDomainNameLabel);
            }
            if (Optional.IsDefined(TeamsVoicemailPilotNumber))
            {
                writer.WritePropertyName("teamsVoicemailPilotNumber"u8);
                writer.WriteStringValue(TeamsVoicemailPilotNumber);
            }
            if (Optional.IsDefined(IsOnPremMcpEnabled))
            {
                writer.WritePropertyName("onPremMcpEnabled"u8);
                writer.WriteBooleanValue(IsOnPremMcpEnabled.Value);
            }
            if (Optional.IsCollectionDefined(EmergencyDialStrings))
            {
                writer.WritePropertyName("emergencyDialStrings"u8);
                writer.WriteStartArray();
                foreach (var item in EmergencyDialStrings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        VoiceServicesCommunicationsGatewayData IJsonModel<VoiceServicesCommunicationsGatewayData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesCommunicationsGatewayData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VoiceServicesCommunicationsGatewayData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVoiceServicesCommunicationsGatewayData(document.RootElement, options);
        }

        internal static VoiceServicesCommunicationsGatewayData DeserializeVoiceServicesCommunicationsGatewayData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            VoiceServicesProvisioningState? provisioningState = default;
            VoiceServicesCommunicationsGatewayStatus? status = default;
            IList<VoiceServicesServiceRegionProperties> serviceLocations = default;
            VoiceServicesCommunicationsGatewayConnectivity? connectivity = default;
            IList<VoiceServicesTeamsCodec> codecs = default;
            VoiceServicesEmergencyCallType? e911Type = default;
            IList<VoiceServicesCommunicationsPlatform> platforms = default;
            BinaryData apiBridge = default;
            VoiceServicesAutoGeneratedDomainNameLabelScope? autoGeneratedDomainNameLabelScope = default;
            string autoGeneratedDomainNameLabel = default;
            string teamsVoicemailPilotNumber = default;
            bool? onPremMcpEnabled = default;
            IList<string> emergencyDialStrings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerVoiceServicesContext.Default);
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VoiceServicesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new VoiceServicesCommunicationsGatewayStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceLocations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VoiceServicesServiceRegionProperties> array = new List<VoiceServicesServiceRegionProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VoiceServicesServiceRegionProperties.DeserializeVoiceServicesServiceRegionProperties(item, options));
                            }
                            serviceLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("connectivity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectivity = new VoiceServicesCommunicationsGatewayConnectivity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("codecs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VoiceServicesTeamsCodec> array = new List<VoiceServicesTeamsCodec>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new VoiceServicesTeamsCodec(item.GetString()));
                            }
                            codecs = array;
                            continue;
                        }
                        if (property0.NameEquals("e911Type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            e911Type = new VoiceServicesEmergencyCallType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("platforms"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VoiceServicesCommunicationsPlatform> array = new List<VoiceServicesCommunicationsPlatform>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new VoiceServicesCommunicationsPlatform(item.GetString()));
                            }
                            platforms = array;
                            continue;
                        }
                        if (property0.NameEquals("apiBridge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiBridge = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("autoGeneratedDomainNameLabelScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoGeneratedDomainNameLabelScope = new VoiceServicesAutoGeneratedDomainNameLabelScope(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("autoGeneratedDomainNameLabel"u8))
                        {
                            autoGeneratedDomainNameLabel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("teamsVoicemailPilotNumber"u8))
                        {
                            teamsVoicemailPilotNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("onPremMcpEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            onPremMcpEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("emergencyDialStrings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            emergencyDialStrings = array;
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
            return new VoiceServicesCommunicationsGatewayData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                provisioningState,
                status,
                serviceLocations ?? new ChangeTrackingList<VoiceServicesServiceRegionProperties>(),
                connectivity,
                codecs ?? new ChangeTrackingList<VoiceServicesTeamsCodec>(),
                e911Type,
                platforms ?? new ChangeTrackingList<VoiceServicesCommunicationsPlatform>(),
                apiBridge,
                autoGeneratedDomainNameLabelScope,
                autoGeneratedDomainNameLabel,
                teamsVoicemailPilotNumber,
                onPremMcpEnabled,
                emergencyDialStrings ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VoiceServicesCommunicationsGatewayData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesCommunicationsGatewayData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerVoiceServicesContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VoiceServicesCommunicationsGatewayData)} does not support writing '{options.Format}' format.");
            }
        }

        VoiceServicesCommunicationsGatewayData IPersistableModel<VoiceServicesCommunicationsGatewayData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesCommunicationsGatewayData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVoiceServicesCommunicationsGatewayData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VoiceServicesCommunicationsGatewayData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VoiceServicesCommunicationsGatewayData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
