// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ServiceBus;

/// <summary>
/// Properties to configure Encryption.
/// </summary>
public partial class ServiceBusEncryption : ProvisionableConstruct
{
    /// <summary>
    /// Properties of KeyVault.
    /// </summary>
    public BicepList<ServiceBusKeyVaultProperties> KeyVaultProperties { get => _keyVaultProperties; set => _keyVaultProperties.Assign(value); }
    private readonly BicepList<ServiceBusKeyVaultProperties> _keyVaultProperties;

    /// <summary>
    /// Enumerates the possible value of keySource for Encryption.
    /// </summary>
    public BicepValue<ServiceBusEncryptionKeySource> KeySource { get => _keySource; set => _keySource.Assign(value); }
    private readonly BicepValue<ServiceBusEncryptionKeySource> _keySource;

    /// <summary>
    /// Enable Infrastructure Encryption (Double Encryption).
    /// </summary>
    public BicepValue<bool> RequireInfrastructureEncryption { get => _requireInfrastructureEncryption; set => _requireInfrastructureEncryption.Assign(value); }
    private readonly BicepValue<bool> _requireInfrastructureEncryption;

    /// <summary>
    /// Creates a new ServiceBusEncryption.
    /// </summary>
    public ServiceBusEncryption()
    {
        _keyVaultProperties = BicepList<ServiceBusKeyVaultProperties>.DefineProperty(this, "KeyVaultProperties", ["keyVaultProperties"]);
        _keySource = BicepValue<ServiceBusEncryptionKeySource>.DefineProperty(this, "KeySource", ["keySource"]);
        _requireInfrastructureEncryption = BicepValue<bool>.DefineProperty(this, "RequireInfrastructureEncryption", ["requireInfrastructureEncryption"]);
    }
}
