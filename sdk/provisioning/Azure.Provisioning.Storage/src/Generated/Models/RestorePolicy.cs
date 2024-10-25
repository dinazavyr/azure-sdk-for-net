// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// The blob service properties for blob restore policy.
/// </summary>
public partial class RestorePolicy : ProvisionableConstruct
{
    /// <summary>
    /// Blob restore is enabled if set to true.
    /// </summary>
    public BicepValue<bool> IsEnabled { get => _isEnabled; set => _isEnabled.Assign(value); }
    private readonly BicepValue<bool> _isEnabled;

    /// <summary>
    /// how long this blob can be restored. It should be great than zero and
    /// less than DeleteRetentionPolicy.days.
    /// </summary>
    public BicepValue<int> Days { get => _days; set => _days.Assign(value); }
    private readonly BicepValue<int> _days;

    /// <summary>
    /// Deprecated in favor of minRestoreTime property.
    /// </summary>
    public BicepValue<DateTimeOffset> LastEnabledOn { get => _lastEnabledOn; }
    private readonly BicepValue<DateTimeOffset> _lastEnabledOn;

    /// <summary>
    /// Returns the minimum date and time that the restore can be started.
    /// </summary>
    public BicepValue<DateTimeOffset> MinRestoreOn { get => _minRestoreOn; }
    private readonly BicepValue<DateTimeOffset> _minRestoreOn;

    /// <summary>
    /// Creates a new RestorePolicy.
    /// </summary>
    public RestorePolicy()
    {
        _isEnabled = BicepValue<bool>.DefineProperty(this, "IsEnabled", ["enabled"]);
        _days = BicepValue<int>.DefineProperty(this, "Days", ["days"]);
        _lastEnabledOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastEnabledOn", ["lastEnabledTime"], isOutput: true);
        _minRestoreOn = BicepValue<DateTimeOffset>.DefineProperty(this, "MinRestoreOn", ["minRestoreTime"], isOutput: true);
    }
}
