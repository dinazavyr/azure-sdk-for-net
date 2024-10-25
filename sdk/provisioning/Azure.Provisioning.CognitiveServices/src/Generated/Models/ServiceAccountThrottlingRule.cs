// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// The ServiceAccountThrottlingRule.
/// </summary>
public partial class ServiceAccountThrottlingRule : ProvisionableConstruct
{
    /// <summary>
    /// Gets the key.
    /// </summary>
    public BicepValue<string> Key { get => _key; }
    private readonly BicepValue<string> _key;

    /// <summary>
    /// Gets the renewal period.
    /// </summary>
    public BicepValue<float> RenewalPeriod { get => _renewalPeriod; }
    private readonly BicepValue<float> _renewalPeriod;

    /// <summary>
    /// Gets the count.
    /// </summary>
    public BicepValue<float> Count { get => _count; }
    private readonly BicepValue<float> _count;

    /// <summary>
    /// Gets the min count.
    /// </summary>
    public BicepValue<float> MinCount { get => _minCount; }
    private readonly BicepValue<float> _minCount;

    /// <summary>
    /// Gets the is dynamic throttling enabled.
    /// </summary>
    public BicepValue<bool> IsDynamicThrottlingEnabled { get => _isDynamicThrottlingEnabled; }
    private readonly BicepValue<bool> _isDynamicThrottlingEnabled;

    /// <summary>
    /// Gets the match patterns.
    /// </summary>
    public BicepList<ServiceAccountThrottlingMatchPattern> MatchPatterns { get => _matchPatterns; }
    private readonly BicepList<ServiceAccountThrottlingMatchPattern> _matchPatterns;

    /// <summary>
    /// Creates a new ServiceAccountThrottlingRule.
    /// </summary>
    public ServiceAccountThrottlingRule()
    {
        _key = BicepValue<string>.DefineProperty(this, "Key", ["key"], isOutput: true);
        _renewalPeriod = BicepValue<float>.DefineProperty(this, "RenewalPeriod", ["renewalPeriod"], isOutput: true);
        _count = BicepValue<float>.DefineProperty(this, "Count", ["count"], isOutput: true);
        _minCount = BicepValue<float>.DefineProperty(this, "MinCount", ["minCount"], isOutput: true);
        _isDynamicThrottlingEnabled = BicepValue<bool>.DefineProperty(this, "IsDynamicThrottlingEnabled", ["dynamicThrottlingEnabled"], isOutput: true);
        _matchPatterns = BicepList<ServiceAccountThrottlingMatchPattern>.DefineProperty(this, "MatchPatterns", ["matchPatterns"], isOutput: true);
    }
}
