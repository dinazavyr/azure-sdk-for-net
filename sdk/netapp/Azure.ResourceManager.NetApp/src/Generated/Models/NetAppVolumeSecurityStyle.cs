// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// The security style of volume, default unix, defaults to ntfs for dual protocol or CIFS protocol
    /// Serialized Name: SecurityStyle
    /// </summary>
    public readonly partial struct NetAppVolumeSecurityStyle : IEquatable<NetAppVolumeSecurityStyle>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeSecurityStyle"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppVolumeSecurityStyle(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NtfsValue = "ntfs";
        private const string UnixValue = "unix";

        /// <summary>
        /// ntfs
        /// Serialized Name: SecurityStyle.ntfs
        /// </summary>
        public static NetAppVolumeSecurityStyle Ntfs { get; } = new NetAppVolumeSecurityStyle(NtfsValue);
        /// <summary>
        /// unix
        /// Serialized Name: SecurityStyle.unix
        /// </summary>
        public static NetAppVolumeSecurityStyle Unix { get; } = new NetAppVolumeSecurityStyle(UnixValue);
        /// <summary> Determines if two <see cref="NetAppVolumeSecurityStyle"/> values are the same. </summary>
        public static bool operator ==(NetAppVolumeSecurityStyle left, NetAppVolumeSecurityStyle right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppVolumeSecurityStyle"/> values are not the same. </summary>
        public static bool operator !=(NetAppVolumeSecurityStyle left, NetAppVolumeSecurityStyle right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppVolumeSecurityStyle"/>. </summary>
        public static implicit operator NetAppVolumeSecurityStyle(string value) => new NetAppVolumeSecurityStyle(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppVolumeSecurityStyle other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppVolumeSecurityStyle other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
