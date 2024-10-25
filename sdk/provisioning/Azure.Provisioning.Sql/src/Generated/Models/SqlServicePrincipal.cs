// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// The managed instance&apos;s service principal configuration for a resource.
/// </summary>
public partial class SqlServicePrincipal : ProvisionableConstruct
{
    /// <summary>
    /// The Azure Active Directory application object id.
    /// </summary>
    public BicepValue<Guid> PrincipalId { get => _principalId; }
    private readonly BicepValue<Guid> _principalId;

    /// <summary>
    /// The Azure Active Directory application client id.
    /// </summary>
    public BicepValue<Guid> ClientId { get => _clientId; }
    private readonly BicepValue<Guid> _clientId;

    /// <summary>
    /// The Azure Active Directory tenant id.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// Service principal type.
    /// </summary>
    public BicepValue<SqlServicePrincipalType> PrincipalType { get => _principalType; set => _principalType.Assign(value); }
    private readonly BicepValue<SqlServicePrincipalType> _principalType;

    /// <summary>
    /// Creates a new SqlServicePrincipal.
    /// </summary>
    public SqlServicePrincipal()
    {
        _principalId = BicepValue<Guid>.DefineProperty(this, "PrincipalId", ["principalId"], isOutput: true);
        _clientId = BicepValue<Guid>.DefineProperty(this, "ClientId", ["clientId"], isOutput: true);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"], isOutput: true);
        _principalType = BicepValue<SqlServicePrincipalType>.DefineProperty(this, "PrincipalType", ["type"]);
    }
}
