// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Azure File Properties.
/// </summary>
public partial class ContainerAppAzureFileProperties : ProvisionableConstruct
{
    /// <summary>
    /// Storage account name for azure file.
    /// </summary>
    public BicepValue<string> AccountName { get => _accountName; set => _accountName.Assign(value); }
    private readonly BicepValue<string> _accountName;

    /// <summary>
    /// Storage account key for azure file.
    /// </summary>
    public BicepValue<string> AccountKey { get => _accountKey; set => _accountKey.Assign(value); }
    private readonly BicepValue<string> _accountKey;

    /// <summary>
    /// Access mode for storage.
    /// </summary>
    public BicepValue<ContainerAppAccessMode> AccessMode { get => _accessMode; set => _accessMode.Assign(value); }
    private readonly BicepValue<ContainerAppAccessMode> _accessMode;

    /// <summary>
    /// Azure file share name.
    /// </summary>
    public BicepValue<string> ShareName { get => _shareName; set => _shareName.Assign(value); }
    private readonly BicepValue<string> _shareName;

    /// <summary>
    /// Creates a new ContainerAppAzureFileProperties.
    /// </summary>
    public ContainerAppAzureFileProperties()
    {
        _accountName = BicepValue<string>.DefineProperty(this, "AccountName", ["accountName"]);
        _accountKey = BicepValue<string>.DefineProperty(this, "AccountKey", ["accountKey"]);
        _accessMode = BicepValue<ContainerAppAccessMode>.DefineProperty(this, "AccessMode", ["accessMode"]);
        _shareName = BicepValue<string>.DefineProperty(this, "ShareName", ["shareName"]);
    }
}
