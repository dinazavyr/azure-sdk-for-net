// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// PostgreSqlServerSecurityAlertPolicy.
/// </summary>
public partial class PostgreSqlServerSecurityAlertPolicy : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Specifies an array of alerts that are disabled. Allowed values are:
    /// Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly.
    /// </summary>
    public BicepList<string> DisabledAlerts { get => _disabledAlerts; set => _disabledAlerts.Assign(value); }
    private readonly BicepList<string> _disabledAlerts;

    /// <summary>
    /// Specifies an array of e-mail addresses to which the alert is sent.
    /// </summary>
    public BicepList<string> EmailAddresses { get => _emailAddresses; set => _emailAddresses.Assign(value); }
    private readonly BicepList<string> _emailAddresses;

    /// <summary>
    /// Specifies the number of days to keep in the Threat Detection audit logs.
    /// </summary>
    public BicepValue<int> RetentionDays { get => _retentionDays; set => _retentionDays.Assign(value); }
    private readonly BicepValue<int> _retentionDays;

    /// <summary>
    /// Specifies that the alert is sent to the account administrators.
    /// </summary>
    public BicepValue<bool> SendToEmailAccountAdmins { get => _sendToEmailAccountAdmins; set => _sendToEmailAccountAdmins.Assign(value); }
    private readonly BicepValue<bool> _sendToEmailAccountAdmins;

    /// <summary>
    /// Specifies the state of the policy, whether it is enabled or disabled.
    /// </summary>
    public BicepValue<PostgreSqlServerSecurityAlertPolicyState> State { get => _state; set => _state.Assign(value); }
    private readonly BicepValue<PostgreSqlServerSecurityAlertPolicyState> _state;

    /// <summary>
    /// Specifies the identifier key of the Threat Detection audit storage
    /// account.
    /// </summary>
    public BicepValue<string> StorageAccountAccessKey { get => _storageAccountAccessKey; set => _storageAccountAccessKey.Assign(value); }
    private readonly BicepValue<string> _storageAccountAccessKey;

    /// <summary>
    /// Specifies the blob storage endpoint (e.g.
    /// https://MyAccount.blob.core.windows.net). This blob storage will hold
    /// all Threat Detection audit logs.
    /// </summary>
    public BicepValue<string> StorageEndpoint { get => _storageEndpoint; set => _storageEndpoint.Assign(value); }
    private readonly BicepValue<string> _storageEndpoint;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent PostgreSqlServer.
    /// </summary>
    public PostgreSqlServer? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<PostgreSqlServer> _parent;

    /// <summary>
    /// Creates a new PostgreSqlServerSecurityAlertPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// PostgreSqlServerSecurityAlertPolicy resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlServerSecurityAlertPolicy.</param>
    public PostgreSqlServerSecurityAlertPolicy(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DBforPostgreSQL/servers/securityAlertPolicies", resourceVersion ?? "2017-12-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _disabledAlerts = BicepList<string>.DefineProperty(this, "DisabledAlerts", ["properties", "disabledAlerts"]);
        _emailAddresses = BicepList<string>.DefineProperty(this, "EmailAddresses", ["properties", "emailAddresses"]);
        _retentionDays = BicepValue<int>.DefineProperty(this, "RetentionDays", ["properties", "retentionDays"]);
        _sendToEmailAccountAdmins = BicepValue<bool>.DefineProperty(this, "SendToEmailAccountAdmins", ["properties", "emailAccountAdmins"]);
        _state = BicepValue<PostgreSqlServerSecurityAlertPolicyState>.DefineProperty(this, "State", ["properties", "state"]);
        _storageAccountAccessKey = BicepValue<string>.DefineProperty(this, "StorageAccountAccessKey", ["properties", "storageAccountAccessKey"]);
        _storageEndpoint = BicepValue<string>.DefineProperty(this, "StorageEndpoint", ["properties", "storageEndpoint"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<PostgreSqlServer>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported PostgreSqlServerSecurityAlertPolicy resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2017-12-01.
        /// </summary>
        public static readonly string V2017_12_01 = "2017-12-01";
    }

    /// <summary>
    /// Creates a reference to an existing PostgreSqlServerSecurityAlertPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the
    /// PostgreSqlServerSecurityAlertPolicy resource.  This can be used to
    /// refer to the resource in expressions, but is not the Azure name of the
    /// resource.  This value can contain letters, numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the PostgreSqlServerSecurityAlertPolicy.</param>
    /// <returns>The existing PostgreSqlServerSecurityAlertPolicy resource.</returns>
    public static PostgreSqlServerSecurityAlertPolicy FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
