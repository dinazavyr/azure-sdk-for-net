// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.ApplicationInsights;

/// <summary>
/// Geo-physical location to run a WebTest from. You must specify one or more
/// locations for the test to run from.
/// </summary>
public partial class WebTestGeolocation : ProvisionableConstruct
{
    /// <summary>
    /// Location ID for the WebTest to run from.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Creates a new WebTestGeolocation.
    /// </summary>
    public WebTestGeolocation()
    {
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["Id"]);
    }
}
