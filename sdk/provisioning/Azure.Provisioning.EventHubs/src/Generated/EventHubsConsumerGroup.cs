// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.EventHubs;

/// <summary>
/// EventHubsConsumerGroup.
/// </summary>
public partial class EventHubsConsumerGroup : ProvisionableResource
{
    /// <summary>
    /// The consumer group name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// User Metadata is a placeholder to store user-defined string data with
    /// maximum length 1024. e.g. it can be used to store descriptive data,
    /// such as list of teams and their contact information also user-defined
    /// configuration settings can be stored.
    /// </summary>
    public BicepValue<string> UserMetadata { get => _userMetadata; set => _userMetadata.Assign(value); }
    private readonly BicepValue<string> _userMetadata;

    /// <summary>
    /// Exact time the message was created.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// The geo-location where the resource lives.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// The exact time the message was updated.
    /// </summary>
    public BicepValue<DateTimeOffset> UpdatedOn { get => _updatedOn; }
    private readonly BicepValue<DateTimeOffset> _updatedOn;

    /// <summary>
    /// Gets or sets a reference to the parent EventHub.
    /// </summary>
    public EventHub? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EventHub> _parent;

    /// <summary>
    /// Creates a new EventHubsConsumerGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHubsConsumerGroup resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHubsConsumerGroup.</param>
    public EventHubsConsumerGroup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.EventHub/namespaces/eventhubs/consumergroups", resourceVersion ?? "2024-01-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _userMetadata = BicepValue<string>.DefineProperty(this, "UserMetadata", ["properties", "userMetadata"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "createdAt"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _updatedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "UpdatedOn", ["properties", "updatedAt"], isOutput: true);
        _parent = ResourceReference<EventHub>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported EventHubsConsumerGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2017-04-01.
        /// </summary>
        public static readonly string V2017_04_01 = "2017-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing EventHubsConsumerGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the EventHubsConsumerGroup resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the EventHubsConsumerGroup.</param>
    /// <returns>The existing EventHubsConsumerGroup resource.</returns>
    public static EventHubsConsumerGroup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this EventHubsConsumerGroup resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 50, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period);
}
