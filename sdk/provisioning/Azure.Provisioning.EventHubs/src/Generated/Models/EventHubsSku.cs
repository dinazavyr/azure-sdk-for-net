// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// SKU parameters supplied to the create namespace operation.
/// </summary>
public partial class EventHubsSku : ProvisionableConstruct
{
    /// <summary>
    /// Name of this SKU.
    /// </summary>
    public BicepValue<EventHubsSkuName> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<EventHubsSkuName> _name;

    /// <summary>
    /// The billing tier of this particular SKU.
    /// </summary>
    public BicepValue<EventHubsSkuTier> Tier { get => _tier; set => _tier.Assign(value); }
    private readonly BicepValue<EventHubsSkuTier> _tier;

    /// <summary>
    /// The Event Hubs throughput units for Basic or Standard tiers, where
    /// value should be 0 to 20 throughput units. The Event Hubs premium units
    /// for Premium tier, where value should be 0 to 10 premium units.
    /// </summary>
    public BicepValue<int> Capacity { get => _capacity; set => _capacity.Assign(value); }
    private readonly BicepValue<int> _capacity;

    /// <summary>
    /// Creates a new EventHubsSku.
    /// </summary>
    public EventHubsSku()
    {
        _name = BicepValue<EventHubsSkuName>.DefineProperty(this, "Name", ["name"]);
        _tier = BicepValue<EventHubsSkuTier>.DefineProperty(this, "Tier", ["tier"]);
        _capacity = BicepValue<int>.DefineProperty(this, "Capacity", ["capacity"]);
    }
}
