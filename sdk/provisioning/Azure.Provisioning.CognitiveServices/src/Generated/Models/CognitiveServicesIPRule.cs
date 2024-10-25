// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// A rule governing the accessibility from a specific ip address or ip range.
/// </summary>
public partial class CognitiveServicesIPRule : ProvisionableConstruct
{
    /// <summary>
    /// An IPv4 address range in CIDR notation, such as
    /// &apos;124.56.78.91&apos; (simple IP address) or
    /// &apos;124.56.78.0/24&apos; (all addresses that start with 124.56.78).
    /// </summary>
    public BicepValue<string> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<string> _value;

    /// <summary>
    /// Creates a new CognitiveServicesIPRule.
    /// </summary>
    public CognitiveServicesIPRule()
    {
        _value = BicepValue<string>.DefineProperty(this, "Value", ["value"]);
    }
}
