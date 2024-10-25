// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// Properties of the vault.
/// </summary>
public partial class KeyVaultProperties : ProvisionableConstruct
{
    /// <summary>
    /// The Azure Active Directory tenant ID that should be used for
    /// authenticating requests to the key vault.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; set => _tenantId.Assign(value); }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// SKU details.
    /// </summary>
    public BicepValue<KeyVaultSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<KeyVaultSku> _sku;

    /// <summary>
    /// An array of 0 to 1024 identities that have access to the key vault. All
    /// identities in the array must use the same tenant ID as the key
    /// vault&apos;s tenant ID. When `createMode` is set to `recover`, access
    /// policies are not required. Otherwise, access policies are required.
    /// </summary>
    public BicepList<KeyVaultAccessPolicy> AccessPolicies { get => _accessPolicies; set => _accessPolicies.Assign(value); }
    private readonly BicepList<KeyVaultAccessPolicy> _accessPolicies;

    /// <summary>
    /// The URI of the vault for performing operations on keys and secrets.
    /// </summary>
    public BicepValue<Uri> VaultUri { get => _vaultUri; set => _vaultUri.Assign(value); }
    private readonly BicepValue<Uri> _vaultUri;

    /// <summary>
    /// The resource id of HSM Pool.
    /// </summary>
    public BicepValue<string> HsmPoolResourceId { get => _hsmPoolResourceId; }
    private readonly BicepValue<string> _hsmPoolResourceId;

    /// <summary>
    /// Property to specify whether Azure Virtual Machines are permitted to
    /// retrieve certificates stored as secrets from the key vault.
    /// </summary>
    public BicepValue<bool> EnabledForDeployment { get => _enabledForDeployment; set => _enabledForDeployment.Assign(value); }
    private readonly BicepValue<bool> _enabledForDeployment;

    /// <summary>
    /// Property to specify whether Azure Disk Encryption is permitted to
    /// retrieve secrets from the vault and unwrap keys.
    /// </summary>
    public BicepValue<bool> EnabledForDiskEncryption { get => _enabledForDiskEncryption; set => _enabledForDiskEncryption.Assign(value); }
    private readonly BicepValue<bool> _enabledForDiskEncryption;

    /// <summary>
    /// Property to specify whether Azure Resource Manager is permitted to
    /// retrieve secrets from the key vault.
    /// </summary>
    public BicepValue<bool> EnabledForTemplateDeployment { get => _enabledForTemplateDeployment; set => _enabledForTemplateDeployment.Assign(value); }
    private readonly BicepValue<bool> _enabledForTemplateDeployment;

    /// <summary>
    /// Property to specify whether the &apos;soft delete&apos; functionality
    /// is enabled for this key vault. If it&apos;s not set to any value(true
    /// or false) when creating new key vault, it will be set to true by
    /// default. Once set to true, it cannot be reverted to false.
    /// </summary>
    public BicepValue<bool> EnableSoftDelete { get => _enableSoftDelete; set => _enableSoftDelete.Assign(value); }
    private readonly BicepValue<bool> _enableSoftDelete;

    /// <summary>
    /// softDelete data retention days. It accepts &gt;=7 and &lt;=90.
    /// </summary>
    public BicepValue<int> SoftDeleteRetentionInDays { get => _softDeleteRetentionInDays; set => _softDeleteRetentionInDays.Assign(value); }
    private readonly BicepValue<int> _softDeleteRetentionInDays;

    /// <summary>
    /// Property that controls how data actions are authorized. When true, the
    /// key vault will use Role Based Access Control (RBAC) for authorization
    /// of data actions, and the access policies specified in vault properties
    /// will be  ignored. When false, the key vault will use the access
    /// policies specified in vault properties, and any policy stored on Azure
    /// Resource Manager will be ignored. If null or not specified, the vault
    /// is created with the default value of false. Note that management
    /// actions are always authorized with RBAC.
    /// </summary>
    public BicepValue<bool> EnableRbacAuthorization { get => _enableRbacAuthorization; set => _enableRbacAuthorization.Assign(value); }
    private readonly BicepValue<bool> _enableRbacAuthorization;

    /// <summary>
    /// The vault&apos;s create mode to indicate whether the vault need to be
    /// recovered or not.
    /// </summary>
    public BicepValue<KeyVaultCreateMode> CreateMode { get => _createMode; set => _createMode.Assign(value); }
    private readonly BicepValue<KeyVaultCreateMode> _createMode;

    /// <summary>
    /// Property specifying whether protection against purge is enabled for
    /// this vault. Setting this property to true activates protection against
    /// purge for this vault and its content - only the Key Vault service may
    /// initiate a hard, irrecoverable deletion. The setting is effective only
    /// if soft delete is also enabled. Enabling this functionality is
    /// irreversible - that is, the property does not accept false as its
    /// value.
    /// </summary>
    public BicepValue<bool> EnablePurgeProtection { get => _enablePurgeProtection; set => _enablePurgeProtection.Assign(value); }
    private readonly BicepValue<bool> _enablePurgeProtection;

    /// <summary>
    /// Rules governing the accessibility of the key vault from specific
    /// network locations.
    /// </summary>
    public BicepValue<KeyVaultNetworkRuleSet> NetworkRuleSet { get => _networkRuleSet; set => _networkRuleSet.Assign(value); }
    private readonly BicepValue<KeyVaultNetworkRuleSet> _networkRuleSet;

    /// <summary>
    /// Provisioning state of the vault.
    /// </summary>
    public BicepValue<KeyVaultProvisioningState> ProvisioningState { get => _provisioningState; set => _provisioningState.Assign(value); }
    private readonly BicepValue<KeyVaultProvisioningState> _provisioningState;

    /// <summary>
    /// List of private endpoint connections associated with the key vault.
    /// </summary>
    public BicepList<KeyVaultPrivateEndpointConnectionItemData> PrivateEndpointConnections { get => _privateEndpointConnections; }
    private readonly BicepList<KeyVaultPrivateEndpointConnectionItemData> _privateEndpointConnections;

    /// <summary>
    /// Property to specify whether the vault will accept traffic from public
    /// internet. If set to &apos;disabled&apos; all traffic except private
    /// endpoint traffic and that that originates from trusted services will
    /// be blocked. This will override the set firewall rules, meaning that
    /// even if the firewall rules are present we will not honor the rules.
    /// </summary>
    public BicepValue<string> PublicNetworkAccess { get => _publicNetworkAccess; set => _publicNetworkAccess.Assign(value); }
    private readonly BicepValue<string> _publicNetworkAccess;

    /// <summary>
    /// Creates a new KeyVaultProperties.
    /// </summary>
    public KeyVaultProperties()
    {
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"]);
        _sku = BicepValue<KeyVaultSku>.DefineProperty(this, "Sku", ["sku"]);
        _accessPolicies = BicepList<KeyVaultAccessPolicy>.DefineProperty(this, "AccessPolicies", ["accessPolicies"]);
        _vaultUri = BicepValue<Uri>.DefineProperty(this, "VaultUri", ["vaultUri"]);
        _hsmPoolResourceId = BicepValue<string>.DefineProperty(this, "HsmPoolResourceId", ["hsmPoolResourceId"], isOutput: true);
        _enabledForDeployment = BicepValue<bool>.DefineProperty(this, "EnabledForDeployment", ["enabledForDeployment"]);
        _enabledForDiskEncryption = BicepValue<bool>.DefineProperty(this, "EnabledForDiskEncryption", ["enabledForDiskEncryption"]);
        _enabledForTemplateDeployment = BicepValue<bool>.DefineProperty(this, "EnabledForTemplateDeployment", ["enabledForTemplateDeployment"]);
        _enableSoftDelete = BicepValue<bool>.DefineProperty(this, "EnableSoftDelete", ["enableSoftDelete"]);
        _softDeleteRetentionInDays = BicepValue<int>.DefineProperty(this, "SoftDeleteRetentionInDays", ["softDeleteRetentionInDays"]);
        _enableRbacAuthorization = BicepValue<bool>.DefineProperty(this, "EnableRbacAuthorization", ["enableRbacAuthorization"]);
        _createMode = BicepValue<KeyVaultCreateMode>.DefineProperty(this, "CreateMode", ["createMode"]);
        _enablePurgeProtection = BicepValue<bool>.DefineProperty(this, "EnablePurgeProtection", ["enablePurgeProtection"]);
        _networkRuleSet = BicepValue<KeyVaultNetworkRuleSet>.DefineProperty(this, "NetworkRuleSet", ["networkAcls"]);
        _provisioningState = BicepValue<KeyVaultProvisioningState>.DefineProperty(this, "ProvisioningState", ["provisioningState"]);
        _privateEndpointConnections = BicepList<KeyVaultPrivateEndpointConnectionItemData>.DefineProperty(this, "PrivateEndpointConnections", ["privateEndpointConnections"], isOutput: true);
        _publicNetworkAccess = BicepValue<string>.DefineProperty(this, "PublicNetworkAccess", ["publicNetworkAccess"]);
    }
}
