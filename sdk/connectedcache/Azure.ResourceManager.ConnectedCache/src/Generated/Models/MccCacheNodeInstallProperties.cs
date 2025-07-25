// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ConnectedCache.Models
{
    /// <summary> Mcc cache node resource install script properties. </summary>
    public partial class MccCacheNodeInstallProperties
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

        /// <summary> Initializes a new instance of <see cref="MccCacheNodeInstallProperties"/>. </summary>
        internal MccCacheNodeInstallProperties()
        {
            DriveConfiguration = new ChangeTrackingList<CacheNodeDriveConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="MccCacheNodeInstallProperties"/>. </summary>
        /// <param name="customerId"> Mcc customer resource Id. </param>
        /// <param name="cacheNodeId"> Mcc cache node resource Id. </param>
        /// <param name="primaryAccountKey"> Mcc primary account key. Internal to Mcc. </param>
        /// <param name="secondaryAccountKey"> Mcc secondary account key. Internal to Mcc. </param>
        /// <param name="registrationKey"> Mcc Iot Central temporary device registration key, used once. </param>
        /// <param name="tlsCertificateProvisioningKey"> Mcc Tls certificate provisioning key. </param>
        /// <param name="driveConfiguration"> Cache node resource drive configurations. </param>
        /// <param name="proxyUrlConfiguration"> proxyUrl configuration of the cache node. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MccCacheNodeInstallProperties(string customerId, string cacheNodeId, string primaryAccountKey, string secondaryAccountKey, string registrationKey, string tlsCertificateProvisioningKey, IReadOnlyList<CacheNodeDriveConfiguration> driveConfiguration, MccCacheNodeProxyUriConfiguration proxyUrlConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomerId = customerId;
            CacheNodeId = cacheNodeId;
            PrimaryAccountKey = primaryAccountKey;
            SecondaryAccountKey = secondaryAccountKey;
            RegistrationKey = registrationKey;
            TlsCertificateProvisioningKey = tlsCertificateProvisioningKey;
            DriveConfiguration = driveConfiguration;
            ProxyUrlConfiguration = proxyUrlConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Mcc customer resource Id. </summary>
        public string CustomerId { get; }
        /// <summary> Mcc cache node resource Id. </summary>
        public string CacheNodeId { get; }
        /// <summary> Mcc primary account key. Internal to Mcc. </summary>
        public string PrimaryAccountKey { get; }
        /// <summary> Mcc secondary account key. Internal to Mcc. </summary>
        public string SecondaryAccountKey { get; }
        /// <summary> Mcc Iot Central temporary device registration key, used once. </summary>
        public string RegistrationKey { get; }
        /// <summary> Mcc Tls certificate provisioning key. </summary>
        public string TlsCertificateProvisioningKey { get; }
        /// <summary> Cache node resource drive configurations. </summary>
        public IReadOnlyList<CacheNodeDriveConfiguration> DriveConfiguration { get; }
        /// <summary> proxyUrl configuration of the cache node. </summary>
        internal MccCacheNodeProxyUriConfiguration ProxyUrlConfiguration { get; }
        /// <summary> Host Proxy Address configuration along with port number. This can be a proxy or ip address. ex: xx.xx.xx.xxxx:80 or host name http://exampleproxy.com:80. </summary>
        public Uri ProxyUri
        {
            get => ProxyUrlConfiguration?.ProxyUri;
        }
    }
}
