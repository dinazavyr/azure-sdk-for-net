// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// The response from the List namespace operation.
/// </summary>
public partial class EventHubsNetworkRuleSetVirtualNetworkRules : ProvisionableConstruct
{
    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> SubnetId { get => _subnetId; set => _subnetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _subnetId;

    /// <summary>
    /// Value that indicates whether to ignore missing Vnet Service Endpoint.
    /// </summary>
    public BicepValue<bool> IgnoreMissingVnetServiceEndpoint { get => _ignoreMissingVnetServiceEndpoint; set => _ignoreMissingVnetServiceEndpoint.Assign(value); }
    private readonly BicepValue<bool> _ignoreMissingVnetServiceEndpoint;

    /// <summary>
    /// Creates a new EventHubsNetworkRuleSetVirtualNetworkRules.
    /// </summary>
    public EventHubsNetworkRuleSetVirtualNetworkRules()
    {
        _subnetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "SubnetId", ["subnet", "id"]);
        _ignoreMissingVnetServiceEndpoint = BicepValue<bool>.DefineProperty(this, "IgnoreMissingVnetServiceEndpoint", ["ignoreMissingVnetServiceEndpoint"]);
    }
}
