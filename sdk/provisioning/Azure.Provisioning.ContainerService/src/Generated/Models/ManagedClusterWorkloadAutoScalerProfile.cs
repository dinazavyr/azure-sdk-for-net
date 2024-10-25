// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Workload Auto-scaler profile for the managed cluster.
/// </summary>
public partial class ManagedClusterWorkloadAutoScalerProfile : ProvisionableConstruct
{
    /// <summary>
    /// Whether to enable KEDA.
    /// </summary>
    public BicepValue<bool> IsKedaEnabled { get => _isKedaEnabled; set => _isKedaEnabled.Assign(value); }
    private readonly BicepValue<bool> _isKedaEnabled;

    /// <summary>
    /// Whether to enable VPA. Default value is false.
    /// </summary>
    public BicepValue<bool> IsVpaEnabled { get => _isVpaEnabled; set => _isVpaEnabled.Assign(value); }
    private readonly BicepValue<bool> _isVpaEnabled;

    /// <summary>
    /// Creates a new ManagedClusterWorkloadAutoScalerProfile.
    /// </summary>
    public ManagedClusterWorkloadAutoScalerProfile()
    {
        _isKedaEnabled = BicepValue<bool>.DefineProperty(this, "IsKedaEnabled", ["keda", "enabled"]);
        _isVpaEnabled = BicepValue<bool>.DefineProperty(this, "IsVpaEnabled", ["verticalPodAutoscaler", "enabled"]);
    }
}
