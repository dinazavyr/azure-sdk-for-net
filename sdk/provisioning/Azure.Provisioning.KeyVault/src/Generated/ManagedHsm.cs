// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// ManagedHsm.
/// </summary>
public partial class ManagedHsm : ProvisionableResource
{
    /// <summary>
    /// Name of the managed HSM Pool.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Properties of the managed HSM.
    /// </summary>
    public BicepValue<ManagedHsmProperties> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<ManagedHsmProperties> _properties;

    /// <summary>
    /// SKU details.
    /// </summary>
    public BicepValue<ManagedHsmSku> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<ManagedHsmSku> _sku;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

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
    /// Creates a new ManagedHsm.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ManagedHsm resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedHsm.</param>
    public ManagedHsm(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.KeyVault/managedHSMs", resourceVersion ?? "2023-07-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _properties = BicepValue<ManagedHsmProperties>.DefineProperty(this, "Properties", ["properties"]);
        _sku = BicepValue<ManagedHsmSku>.DefineProperty(this, "Sku", ["sku"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ManagedHsm resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-08-01-PREVIEW.
        /// </summary>
        public static readonly string V2023_08_01_PREVIEW = "2023-08-01-PREVIEW";

        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2022-11-01.
        /// </summary>
        public static readonly string V2022_11_01 = "2022-11-01";

        /// <summary>
        /// 2022-07-01.
        /// </summary>
        public static readonly string V2022_07_01 = "2022-07-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";
    }

    /// <summary>
    /// Creates a reference to an existing ManagedHsm.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the ManagedHsm resource.  This can be
    /// used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedHsm.</param>
    /// <returns>The existing ManagedHsm resource.</returns>
    public static ManagedHsm FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
