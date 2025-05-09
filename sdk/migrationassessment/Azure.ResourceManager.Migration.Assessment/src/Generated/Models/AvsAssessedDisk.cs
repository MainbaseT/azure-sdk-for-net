// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    /// <summary> AVS assessed disk web model class. </summary>
    public partial class AvsAssessedDisk
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AvsAssessedDisk"/>. </summary>
        internal AvsAssessedDisk()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AvsAssessedDisk"/>. </summary>
        /// <param name="name"> Gets the ID of the disk. </param>
        /// <param name="displayName"> Gets the display name of the disk. </param>
        /// <param name="gigabytesProvisioned"> Gigabytes Provisioned for a disk in private data center. </param>
        /// <param name="megabytesPerSecondOfRead"> Disk Read Throughput in MB/s. </param>
        /// <param name="megabytesPerSecondOfWrite"> Disk Write Throughput in MB/s. </param>
        /// <param name="numberOfReadOperationsPerSecond"> Read Operations per second. </param>
        /// <param name="numberOfWriteOperationsPerSecond"> Write Operations per second. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsAssessedDisk(string name, string displayName, double? gigabytesProvisioned, double? megabytesPerSecondOfRead, double? megabytesPerSecondOfWrite, double? numberOfReadOperationsPerSecond, double? numberOfWriteOperationsPerSecond, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            DisplayName = displayName;
            GigabytesProvisioned = gigabytesProvisioned;
            MegabytesPerSecondOfRead = megabytesPerSecondOfRead;
            MegabytesPerSecondOfWrite = megabytesPerSecondOfWrite;
            NumberOfReadOperationsPerSecond = numberOfReadOperationsPerSecond;
            NumberOfWriteOperationsPerSecond = numberOfWriteOperationsPerSecond;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the ID of the disk. </summary>
        public string Name { get; }
        /// <summary> Gets the display name of the disk. </summary>
        public string DisplayName { get; }
        /// <summary> Gigabytes Provisioned for a disk in private data center. </summary>
        public double? GigabytesProvisioned { get; }
        /// <summary> Disk Read Throughput in MB/s. </summary>
        public double? MegabytesPerSecondOfRead { get; }
        /// <summary> Disk Write Throughput in MB/s. </summary>
        public double? MegabytesPerSecondOfWrite { get; }
        /// <summary> Read Operations per second. </summary>
        public double? NumberOfReadOperationsPerSecond { get; }
        /// <summary> Write Operations per second. </summary>
        public double? NumberOfWriteOperationsPerSecond { get; }
    }
}
