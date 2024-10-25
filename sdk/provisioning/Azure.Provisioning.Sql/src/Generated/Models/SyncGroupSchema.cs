// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Properties of sync group schema.
/// </summary>
public partial class SyncGroupSchema : ProvisionableConstruct
{
    /// <summary>
    /// List of tables in sync group schema.
    /// </summary>
    public BicepList<SyncGroupSchemaTable> Tables { get => _tables; set => _tables.Assign(value); }
    private readonly BicepList<SyncGroupSchemaTable> _tables;

    /// <summary>
    /// Name of master sync member where the schema is from.
    /// </summary>
    public BicepValue<string> MasterSyncMemberName { get => _masterSyncMemberName; set => _masterSyncMemberName.Assign(value); }
    private readonly BicepValue<string> _masterSyncMemberName;

    /// <summary>
    /// Creates a new SyncGroupSchema.
    /// </summary>
    public SyncGroupSchema()
    {
        _tables = BicepList<SyncGroupSchemaTable>.DefineProperty(this, "Tables", ["tables"]);
        _masterSyncMemberName = BicepValue<string>.DefineProperty(this, "MasterSyncMemberName", ["masterSyncMemberName"]);
    }
}
