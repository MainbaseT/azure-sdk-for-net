// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Specifies whether the IP configuration's public IP is IPv4 or IPv6. Default is IPv4. </summary>
    public readonly partial struct ServiceFabricManagedClusterPublicIPAddressVersion : IEquatable<ServiceFabricManagedClusterPublicIPAddressVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedClusterPublicIPAddressVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceFabricManagedClusterPublicIPAddressVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IPv4Value = "IPv4";
        private const string IPv6Value = "IPv6";

        /// <summary> The IP configuration's public IP is IPv4. </summary>
        public static ServiceFabricManagedClusterPublicIPAddressVersion IPv4 { get; } = new ServiceFabricManagedClusterPublicIPAddressVersion(IPv4Value);
        /// <summary> The IP configuration's public IP is IPv6. </summary>
        public static ServiceFabricManagedClusterPublicIPAddressVersion IPv6 { get; } = new ServiceFabricManagedClusterPublicIPAddressVersion(IPv6Value);
        /// <summary> Determines if two <see cref="ServiceFabricManagedClusterPublicIPAddressVersion"/> values are the same. </summary>
        public static bool operator ==(ServiceFabricManagedClusterPublicIPAddressVersion left, ServiceFabricManagedClusterPublicIPAddressVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceFabricManagedClusterPublicIPAddressVersion"/> values are not the same. </summary>
        public static bool operator !=(ServiceFabricManagedClusterPublicIPAddressVersion left, ServiceFabricManagedClusterPublicIPAddressVersion right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ServiceFabricManagedClusterPublicIPAddressVersion"/>. </summary>
        public static implicit operator ServiceFabricManagedClusterPublicIPAddressVersion(string value) => new ServiceFabricManagedClusterPublicIPAddressVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceFabricManagedClusterPublicIPAddressVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceFabricManagedClusterPublicIPAddressVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
