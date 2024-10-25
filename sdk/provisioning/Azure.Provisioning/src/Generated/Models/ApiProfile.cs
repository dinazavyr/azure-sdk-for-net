// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// ApiProfile.
/// </summary>
public partial class ApiProfile : ProvisionableConstruct
{
    /// <summary>
    /// Gets the ProfileVersion.
    /// </summary>
    public BicepValue<string> ProfileVersion { get => _profileVersion; }
    private readonly BicepValue<string> _profileVersion;

    /// <summary>
    /// Gets the ApiVersion.
    /// </summary>
    public BicepValue<string> ApiVersion { get => _apiVersion; }
    private readonly BicepValue<string> _apiVersion;

    /// <summary>
    /// Creates a new ApiProfile.
    /// </summary>
    public ApiProfile()
    {
        _profileVersion = BicepValue<string>.DefineProperty(this, "ProfileVersion", ["profileVersion"], isOutput: true);
        _apiVersion = BicepValue<string>.DefineProperty(this, "ApiVersion", ["apiVersion"], isOutput: true);
    }
}
