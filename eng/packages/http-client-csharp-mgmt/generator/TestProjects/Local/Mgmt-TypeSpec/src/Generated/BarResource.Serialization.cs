// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace MgmtTypeSpec
{
    /// <summary></summary>
    public partial class BarResource : IJsonModel<BarData>
    {
        private static IJsonModel<BarData> s_dataDeserializationInstance;

        private static IJsonModel<BarData> DataDeserializationInstance => s_dataDeserializationInstance ??= new BarData();

        /// <param name="writer"> The writer to serialize the model to. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        void IJsonModel<BarData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BarData>)Data).Write(writer, options);

        /// <param name="reader"> The reader for deserializing the model. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        BarData IJsonModel<BarData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => DataDeserializationInstance.Create(ref reader, options);

        /// <param name="options"> The client options for reading and writing models. </param>
        BinaryData IPersistableModel<BarData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<BarData>(Data, options, MgmtTypeSpecContext.Default);

        /// <param name="data"> The binary data to be processed. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        BarData IPersistableModel<BarData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BarData>(data, options, MgmtTypeSpecContext.Default);

        /// <param name="options"> The client options for reading and writing models. </param>
        string IPersistableModel<BarData>.GetFormatFromOptions(ModelReaderWriterOptions options) => DataDeserializationInstance.GetFormatFromOptions(options);
    }
}
