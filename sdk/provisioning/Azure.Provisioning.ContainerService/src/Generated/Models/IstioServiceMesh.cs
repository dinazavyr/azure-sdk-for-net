// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Istio service mesh configuration.
/// </summary>
public partial class IstioServiceMesh : ProvisionableConstruct
{
    /// <summary>
    /// Istio components configuration.
    /// </summary>
    public BicepValue<IstioComponents> Components { get => _components; set => _components.Assign(value); }
    private readonly BicepValue<IstioComponents> _components;

    /// <summary>
    /// Plugin certificates information for Service Mesh.
    /// </summary>
    public BicepValue<IstioPluginCertificateAuthority> CertificateAuthorityPlugin { get => _certificateAuthorityPlugin; set => _certificateAuthorityPlugin.Assign(value); }
    private readonly BicepValue<IstioPluginCertificateAuthority> _certificateAuthorityPlugin;

    /// <summary>
    /// The list of revisions of the Istio control plane. When an upgrade is
    /// not in progress, this holds one value. When canary upgrade is in
    /// progress, this can only hold two consecutive values. For more
    /// information, see:
    /// https://learn.microsoft.com/en-us/azure/aks/istio-upgrade.
    /// </summary>
    public BicepList<string> Revisions { get => _revisions; set => _revisions.Assign(value); }
    private readonly BicepList<string> _revisions;

    /// <summary>
    /// Creates a new IstioServiceMesh.
    /// </summary>
    public IstioServiceMesh()
    {
        _components = BicepValue<IstioComponents>.DefineProperty(this, "Components", ["components"]);
        _certificateAuthorityPlugin = BicepValue<IstioPluginCertificateAuthority>.DefineProperty(this, "CertificateAuthorityPlugin", ["certificateAuthority", "plugin"]);
        _revisions = BicepList<string>.DefineProperty(this, "Revisions", ["revisions"]);
    }
}
