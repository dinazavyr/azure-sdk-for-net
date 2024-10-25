// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SyncMember.
/// </summary>
public partial class SyncMember : ProvisionableResource
{
    /// <summary>
    /// The name of the sync member.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Database name of the member database in the sync member.
    /// </summary>
    public BicepValue<string> DatabaseName { get => _databaseName; set => _databaseName.Assign(value); }
    private readonly BicepValue<string> _databaseName;

    /// <summary>
    /// Database type of the sync member.
    /// </summary>
    public BicepValue<SyncMemberDbType> DatabaseType { get => _databaseType; set => _databaseType.Assign(value); }
    private readonly BicepValue<SyncMemberDbType> _databaseType;

    /// <summary>
    /// Password of the member database in the sync member.
    /// </summary>
    public BicepValue<string> Password { get => _password; set => _password.Assign(value); }
    private readonly BicepValue<string> _password;

    /// <summary>
    /// Server name of the member database in the sync member.
    /// </summary>
    public BicepValue<string> ServerName { get => _serverName; set => _serverName.Assign(value); }
    private readonly BicepValue<string> _serverName;

    /// <summary>
    /// SQL Server database id of the sync member.
    /// </summary>
    public BicepValue<Guid> SqlServerDatabaseId { get => _sqlServerDatabaseId; set => _sqlServerDatabaseId.Assign(value); }
    private readonly BicepValue<Guid> _sqlServerDatabaseId;

    /// <summary>
    /// ARM resource id of the sync agent in the sync member.
    /// </summary>
    public BicepValue<ResourceIdentifier> SyncAgentId { get => _syncAgentId; set => _syncAgentId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _syncAgentId;

    /// <summary>
    /// Sync direction of the sync member.
    /// </summary>
    public BicepValue<SyncDirection> SyncDirection { get => _syncDirection; set => _syncDirection.Assign(value); }
    private readonly BicepValue<SyncDirection> _syncDirection;

    /// <summary>
    /// ARM resource id of the sync member logical database, for sync members
    /// in Azure.
    /// </summary>
    public BicepValue<ResourceIdentifier> SyncMemberAzureDatabaseResourceId { get => _syncMemberAzureDatabaseResourceId; set => _syncMemberAzureDatabaseResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _syncMemberAzureDatabaseResourceId;

    /// <summary>
    /// Whether to use private link connection.
    /// </summary>
    public BicepValue<bool> UsePrivateLinkConnection { get => _usePrivateLinkConnection; set => _usePrivateLinkConnection.Assign(value); }
    private readonly BicepValue<bool> _usePrivateLinkConnection;

    /// <summary>
    /// User name of the member database in the sync member.
    /// </summary>
    public BicepValue<string> UserName { get => _userName; set => _userName.Assign(value); }
    private readonly BicepValue<string> _userName;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Private endpoint name of the sync member if use private link connection
    /// is enabled, for sync members in Azure.
    /// </summary>
    public BicepValue<string> PrivateEndpointName { get => _privateEndpointName; }
    private readonly BicepValue<string> _privateEndpointName;

    /// <summary>
    /// Sync state of the sync member.
    /// </summary>
    public BicepValue<SyncMemberState> SyncState { get => _syncState; }
    private readonly BicepValue<SyncMemberState> _syncState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SyncGroup.
    /// </summary>
    public SyncGroup? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SyncGroup> _parent;

    /// <summary>
    /// Creates a new SyncMember.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SyncMember resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SyncMember.</param>
    public SyncMember(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/syncGroups/syncMembers", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _databaseName = BicepValue<string>.DefineProperty(this, "DatabaseName", ["properties", "databaseName"]);
        _databaseType = BicepValue<SyncMemberDbType>.DefineProperty(this, "DatabaseType", ["properties", "databaseType"]);
        _password = BicepValue<string>.DefineProperty(this, "Password", ["properties", "password"]);
        _serverName = BicepValue<string>.DefineProperty(this, "ServerName", ["properties", "serverName"]);
        _sqlServerDatabaseId = BicepValue<Guid>.DefineProperty(this, "SqlServerDatabaseId", ["properties", "sqlServerDatabaseId"]);
        _syncAgentId = BicepValue<ResourceIdentifier>.DefineProperty(this, "SyncAgentId", ["properties", "syncAgentId"]);
        _syncDirection = BicepValue<SyncDirection>.DefineProperty(this, "SyncDirection", ["properties", "syncDirection"]);
        _syncMemberAzureDatabaseResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "SyncMemberAzureDatabaseResourceId", ["properties", "syncMemberAzureDatabaseResourceId"]);
        _usePrivateLinkConnection = BicepValue<bool>.DefineProperty(this, "UsePrivateLinkConnection", ["properties", "usePrivateLinkConnection"]);
        _userName = BicepValue<string>.DefineProperty(this, "UserName", ["properties", "userName"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _privateEndpointName = BicepValue<string>.DefineProperty(this, "PrivateEndpointName", ["properties", "privateEndpointName"], isOutput: true);
        _syncState = BicepValue<SyncMemberState>.DefineProperty(this, "SyncState", ["properties", "syncState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SyncGroup>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SyncMember resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing SyncMember.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the SyncMember resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the SyncMember.</param>
    /// <returns>The existing SyncMember resource.</returns>
    public static SyncMember FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
