// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of a forward proxy used to make the requests.
/// </summary>
public partial class ContainerAppForwardProxy : ProvisionableConstruct
{
    /// <summary>
    /// The convention used to determine the url of the request made.
    /// </summary>
    public BicepValue<ContainerAppForwardProxyConvention> Convention { get => _convention; set => _convention.Assign(value); }
    private readonly BicepValue<ContainerAppForwardProxyConvention> _convention;

    /// <summary>
    /// The name of the header containing the host of the request.
    /// </summary>
    public BicepValue<string> CustomHostHeaderName { get => _customHostHeaderName; set => _customHostHeaderName.Assign(value); }
    private readonly BicepValue<string> _customHostHeaderName;

    /// <summary>
    /// The name of the header containing the scheme of the request.
    /// </summary>
    public BicepValue<string> CustomProtoHeaderName { get => _customProtoHeaderName; set => _customProtoHeaderName.Assign(value); }
    private readonly BicepValue<string> _customProtoHeaderName;

    /// <summary>
    /// Creates a new ContainerAppForwardProxy.
    /// </summary>
    public ContainerAppForwardProxy()
    {
        _convention = BicepValue<ContainerAppForwardProxyConvention>.DefineProperty(this, "Convention", ["convention"]);
        _customHostHeaderName = BicepValue<string>.DefineProperty(this, "CustomHostHeaderName", ["customHostHeaderName"]);
        _customProtoHeaderName = BicepValue<string>.DefineProperty(this, "CustomProtoHeaderName", ["customProtoHeaderName"]);
    }
}
