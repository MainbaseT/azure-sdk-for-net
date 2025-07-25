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

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionModernReservationRecommendation : IUtf8JsonSerializable, IJsonModel<ConsumptionModernReservationRecommendation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionModernReservationRecommendation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConsumptionModernReservationRecommendation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernReservationRecommendation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionModernReservationRecommendation)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LocationPropertiesLocation))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(LocationPropertiesLocation);
            }
            if (options.Format != "W" && Optional.IsDefined(LookBackPeriod))
            {
                writer.WritePropertyName("lookBackPeriod"u8);
                writer.WriteNumberValue(LookBackPeriod.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceFlexibilityRatio))
            {
                writer.WritePropertyName("instanceFlexibilityRatio"u8);
                writer.WriteNumberValue(InstanceFlexibilityRatio.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceFlexibilityGroup))
            {
                writer.WritePropertyName("instanceFlexibilityGroup"u8);
                writer.WriteStringValue(InstanceFlexibilityGroup);
            }
            if (options.Format != "W" && Optional.IsDefined(NormalizedSize))
            {
                writer.WritePropertyName("normalizedSize"u8);
                writer.WriteStringValue(NormalizedSize);
            }
            if (options.Format != "W" && Optional.IsDefined(RecommendedQuantityNormalized))
            {
                writer.WritePropertyName("recommendedQuantityNormalized"u8);
                writer.WriteNumberValue(RecommendedQuantityNormalized.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MeterId))
            {
                writer.WritePropertyName("meterId"u8);
                writer.WriteStringValue(MeterId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term);
            }
            if (options.Format != "W" && Optional.IsDefined(CostWithNoReservedInstances))
            {
                writer.WritePropertyName("costWithNoReservedInstances"u8);
                writer.WriteObjectValue(CostWithNoReservedInstances, options);
            }
            if (options.Format != "W" && Optional.IsDefined(RecommendedQuantity))
            {
                writer.WritePropertyName("recommendedQuantity"u8);
                writer.WriteNumberValue(RecommendedQuantity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalCostWithReservedInstances))
            {
                writer.WritePropertyName("totalCostWithReservedInstances"u8);
                writer.WriteObjectValue(TotalCostWithReservedInstances, options);
            }
            if (options.Format != "W" && Optional.IsDefined(NetSavings))
            {
                writer.WritePropertyName("netSavings"u8);
                writer.WriteObjectValue(NetSavings, options);
            }
            if (options.Format != "W" && Optional.IsDefined(FirstUsageOn))
            {
                writer.WritePropertyName("firstUsageDate"u8);
                writer.WriteStringValue(FirstUsageOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SkuProperties))
            {
                writer.WritePropertyName("skuProperties"u8);
                writer.WriteStartArray();
                foreach (var item in SkuProperties)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(SkuName))
            {
                writer.WritePropertyName("skuName"u8);
                writer.WriteStringValue(SkuName);
            }
            writer.WriteEndObject();
        }

        ConsumptionModernReservationRecommendation IJsonModel<ConsumptionModernReservationRecommendation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernReservationRecommendation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionModernReservationRecommendation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionModernReservationRecommendation(document.RootElement, options);
        }

        internal static ConsumptionModernReservationRecommendation DeserializeConsumptionModernReservationRecommendation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReservationRecommendationKind kind = default;
            AzureLocation? location = default;
            string sku = default;
            ETag? etag = default;
            IReadOnlyDictionary<string, string> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string location0 = default;
            int? lookBackPeriod = default;
            float? instanceFlexibilityRatio = default;
            string instanceFlexibilityGroup = default;
            string normalizedSize = default;
            float? recommendedQuantityNormalized = default;
            Guid? meterId = default;
            string term = default;
            ConsumptionAmount costWithNoReservedInstances = default;
            decimal? recommendedQuantity = default;
            ConsumptionAmount totalCostWithReservedInstances = default;
            ConsumptionAmount netSavings = default;
            DateTimeOffset? firstUsageDate = default;
            string scope = default;
            IReadOnlyList<ConsumptionSkuProperty> skuProperties = default;
            string skuName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new ReservationRecommendationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerConsumptionContext.Default);
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
                        if (property0.NameEquals("location"u8))
                        {
                            location0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lookBackPeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lookBackPeriod = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("instanceFlexibilityRatio"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceFlexibilityRatio = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("instanceFlexibilityGroup"u8))
                        {
                            instanceFlexibilityGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("normalizedSize"u8))
                        {
                            normalizedSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recommendedQuantityNormalized"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recommendedQuantityNormalized = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("meterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            meterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("costWithNoReservedInstances"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            costWithNoReservedInstances = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("recommendedQuantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recommendedQuantity = property0.Value.GetDecimal();
                            continue;
                        }
                        if (property0.NameEquals("totalCostWithReservedInstances"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalCostWithReservedInstances = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("netSavings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            netSavings = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("firstUsageDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            firstUsageDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("skuProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConsumptionSkuProperty> array = new List<ConsumptionSkuProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConsumptionSkuProperty.DeserializeConsumptionSkuProperty(item, options));
                            }
                            skuProperties = array;
                            continue;
                        }
                        if (property0.NameEquals("skuName"u8))
                        {
                            skuName = property0.Value.GetString();
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
            return new ConsumptionModernReservationRecommendation(
                id,
                name,
                type,
                systemData,
                kind,
                location,
                sku,
                etag,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData,
                location0,
                lookBackPeriod,
                instanceFlexibilityRatio,
                instanceFlexibilityGroup,
                normalizedSize,
                recommendedQuantityNormalized,
                meterId,
                term,
                costWithNoReservedInstances,
                recommendedQuantity,
                totalCostWithReservedInstances,
                netSavings,
                firstUsageDate,
                scope,
                skuProperties ?? new ChangeTrackingList<ConsumptionSkuProperty>(),
                skuName);
        }

        BinaryData IPersistableModel<ConsumptionModernReservationRecommendation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernReservationRecommendation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerConsumptionContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionModernReservationRecommendation)} does not support writing '{options.Format}' format.");
            }
        }

        ConsumptionModernReservationRecommendation IPersistableModel<ConsumptionModernReservationRecommendation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernReservationRecommendation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConsumptionModernReservationRecommendation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionModernReservationRecommendation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionModernReservationRecommendation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
