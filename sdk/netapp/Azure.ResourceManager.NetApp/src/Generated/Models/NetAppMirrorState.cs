// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// The status of the replication
    /// Serialized Name: MirrorState
    /// </summary>
    public readonly partial struct NetAppMirrorState : IEquatable<NetAppMirrorState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppMirrorState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppMirrorState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UninitializedValue = "Uninitialized";
        private const string MirroredValue = "Mirrored";
        private const string BrokenValue = "Broken";

        /// <summary>
        /// Uninitialized
        /// Serialized Name: MirrorState.Uninitialized
        /// </summary>
        public static NetAppMirrorState Uninitialized { get; } = new NetAppMirrorState(UninitializedValue);
        /// <summary>
        /// Mirrored
        /// Serialized Name: MirrorState.Mirrored
        /// </summary>
        public static NetAppMirrorState Mirrored { get; } = new NetAppMirrorState(MirroredValue);
        /// <summary>
        /// Broken
        /// Serialized Name: MirrorState.Broken
        /// </summary>
        public static NetAppMirrorState Broken { get; } = new NetAppMirrorState(BrokenValue);
        /// <summary> Determines if two <see cref="NetAppMirrorState"/> values are the same. </summary>
        public static bool operator ==(NetAppMirrorState left, NetAppMirrorState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppMirrorState"/> values are not the same. </summary>
        public static bool operator !=(NetAppMirrorState left, NetAppMirrorState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NetAppMirrorState"/>. </summary>
        public static implicit operator NetAppMirrorState(string value) => new NetAppMirrorState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppMirrorState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppMirrorState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
