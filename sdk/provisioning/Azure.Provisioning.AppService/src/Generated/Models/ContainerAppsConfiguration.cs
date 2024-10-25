// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// The ContainerAppsConfiguration.
/// </summary>
public partial class ContainerAppsConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// Azure Monitor instrumentation key used by Dapr to export Service to
    /// Service communication telemetry.
    /// </summary>
    public BicepValue<string> DaprAIInstrumentationKey { get => _daprAIInstrumentationKey; set => _daprAIInstrumentationKey.Assign(value); }
    private readonly BicepValue<string> _daprAIInstrumentationKey;

    /// <summary>
    /// IP range in CIDR notation that can be reserved for environment
    /// infrastructure IP addresses. It must not overlap with any other Subnet
    /// IP ranges.
    /// </summary>
    public BicepValue<string> PlatformReservedCidr { get => _platformReservedCidr; set => _platformReservedCidr.Assign(value); }
    private readonly BicepValue<string> _platformReservedCidr;

    /// <summary>
    /// An IP address from the IP range defined by platformReservedCidr that
    /// will be reserved for the internal DNS server.
    /// </summary>
    public BicepValue<string> PlatformReservedDnsIP { get => _platformReservedDnsIP; set => _platformReservedDnsIP.Assign(value); }
    private readonly BicepValue<string> _platformReservedDnsIP;

    /// <summary>
    /// Resource ID of a subnet for control plane infrastructure components.
    /// This subnet must be in the same VNET as the subnet defined in
    /// appSubnetResourceId. Must not overlap with the IP range defined in
    /// platformReservedCidr, if defined.
    /// </summary>
    public BicepValue<string> ControlPlaneSubnetResourceId { get => _controlPlaneSubnetResourceId; set => _controlPlaneSubnetResourceId.Assign(value); }
    private readonly BicepValue<string> _controlPlaneSubnetResourceId;

    /// <summary>
    /// Resource ID of a subnet for control plane infrastructure components.
    /// This subnet must be in the same VNET as the subnet defined in
    /// appSubnetResourceId. Must not overlap with the IP range defined in
    /// platformReservedCidr, if defined.
    /// </summary>
    public BicepValue<string> AppSubnetResourceId { get => _appSubnetResourceId; set => _appSubnetResourceId.Assign(value); }
    private readonly BicepValue<string> _appSubnetResourceId;

    /// <summary>
    /// CIDR notation IP range assigned to the Docker bridge network. It must
    /// not overlap with any Subnet IP ranges or the IP range defined in
    /// platformReservedCidr, if defined.
    /// </summary>
    public BicepValue<string> DockerBridgeCidr { get => _dockerBridgeCidr; set => _dockerBridgeCidr.Assign(value); }
    private readonly BicepValue<string> _dockerBridgeCidr;

    /// <summary>
    /// Creates a new ContainerAppsConfiguration.
    /// </summary>
    public ContainerAppsConfiguration()
    {
        _daprAIInstrumentationKey = BicepValue<string>.DefineProperty(this, "DaprAIInstrumentationKey", ["daprAIInstrumentationKey"]);
        _platformReservedCidr = BicepValue<string>.DefineProperty(this, "PlatformReservedCidr", ["platformReservedCidr"]);
        _platformReservedDnsIP = BicepValue<string>.DefineProperty(this, "PlatformReservedDnsIP", ["platformReservedDnsIP"]);
        _controlPlaneSubnetResourceId = BicepValue<string>.DefineProperty(this, "ControlPlaneSubnetResourceId", ["controlPlaneSubnetResourceId"]);
        _appSubnetResourceId = BicepValue<string>.DefineProperty(this, "AppSubnetResourceId", ["appSubnetResourceId"]);
        _dockerBridgeCidr = BicepValue<string>.DefineProperty(this, "DockerBridgeCidr", ["dockerBridgeCidr"]);
    }
}
