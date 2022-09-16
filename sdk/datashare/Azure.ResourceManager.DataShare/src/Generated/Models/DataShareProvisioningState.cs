// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Provisioning state of the Account. </summary>
    public readonly partial struct DataShareProvisioningState : IEquatable<DataShareProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataShareProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataShareProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string MovingValue = "Moving";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static DataShareProvisioningState Succeeded { get; } = new DataShareProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static DataShareProvisioningState Creating { get; } = new DataShareProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static DataShareProvisioningState Deleting { get; } = new DataShareProvisioningState(DeletingValue);
        /// <summary> Moving. </summary>
        public static DataShareProvisioningState Moving { get; } = new DataShareProvisioningState(MovingValue);
        /// <summary> Failed. </summary>
        public static DataShareProvisioningState Failed { get; } = new DataShareProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="DataShareProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DataShareProvisioningState left, DataShareProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataShareProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DataShareProvisioningState left, DataShareProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataShareProvisioningState"/>. </summary>
        public static implicit operator DataShareProvisioningState(string value) => new DataShareProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataShareProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataShareProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
