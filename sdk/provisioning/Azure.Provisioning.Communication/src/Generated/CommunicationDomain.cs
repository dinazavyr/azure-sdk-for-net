// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Communication;

/// <summary>
/// CommunicationDomain.
/// </summary>
public partial class CommunicationDomain : ProvisionableResource
{
    /// <summary>
    /// The name of the Domains resource.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Describes how a Domains resource is being managed.
    /// </summary>
    public BicepValue<DomainManagement> DomainManagement { get => _domainManagement; set => _domainManagement.Assign(value); }
    private readonly BicepValue<DomainManagement> _domainManagement;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Describes whether user engagement tracking is enabled or disabled.
    /// </summary>
    public BicepValue<UserEngagementTracking> UserEngagementTracking { get => _userEngagementTracking; set => _userEngagementTracking.Assign(value); }
    private readonly BicepValue<UserEngagementTracking> _userEngagementTracking;

    /// <summary>
    /// The location where the Domains resource data is stored at rest.
    /// </summary>
    public BicepValue<string> DataLocation { get => _dataLocation; }
    private readonly BicepValue<string> _dataLocation;

    /// <summary>
    /// P2 sender domain that is displayed to the email recipients [RFC 5322].
    /// </summary>
    public BicepValue<string> FromSenderDomain { get => _fromSenderDomain; }
    private readonly BicepValue<string> _fromSenderDomain;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// P1 sender domain that is present on the email envelope [RFC 5321].
    /// </summary>
    public BicepValue<string> MailFromSenderDomain { get => _mailFromSenderDomain; }
    private readonly BicepValue<string> _mailFromSenderDomain;

    /// <summary>
    /// Provisioning state of the resource.
    /// </summary>
    public BicepValue<DomainProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<DomainProvisioningState> _provisioningState;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// List of DnsRecord.
    /// </summary>
    public BicepValue<DomainPropertiesVerificationRecords> VerificationRecords { get => _verificationRecords; }
    private readonly BicepValue<DomainPropertiesVerificationRecords> _verificationRecords;

    /// <summary>
    /// List of VerificationStatusRecord.
    /// </summary>
    public BicepValue<DomainPropertiesVerificationStates> VerificationStates { get => _verificationStates; }
    private readonly BicepValue<DomainPropertiesVerificationStates> _verificationStates;

    /// <summary>
    /// Gets or sets a reference to the parent EmailService.
    /// </summary>
    public EmailService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<EmailService> _parent;

    /// <summary>
    /// Creates a new CommunicationDomain.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CommunicationDomain resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CommunicationDomain.</param>
    public CommunicationDomain(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Communication/emailServices/domains", resourceVersion ?? "2023-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _domainManagement = BicepValue<DomainManagement>.DefineProperty(this, "DomainManagement", ["properties", "domainManagement"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _userEngagementTracking = BicepValue<UserEngagementTracking>.DefineProperty(this, "UserEngagementTracking", ["properties", "userEngagementTracking"]);
        _dataLocation = BicepValue<string>.DefineProperty(this, "DataLocation", ["properties", "dataLocation"], isOutput: true);
        _fromSenderDomain = BicepValue<string>.DefineProperty(this, "FromSenderDomain", ["properties", "fromSenderDomain"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _mailFromSenderDomain = BicepValue<string>.DefineProperty(this, "MailFromSenderDomain", ["properties", "mailFromSenderDomain"], isOutput: true);
        _provisioningState = BicepValue<DomainProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _verificationRecords = BicepValue<DomainPropertiesVerificationRecords>.DefineProperty(this, "VerificationRecords", ["properties", "verificationRecords"], isOutput: true);
        _verificationStates = BicepValue<DomainPropertiesVerificationStates>.DefineProperty(this, "VerificationStates", ["properties", "verificationStates"], isOutput: true);
        _parent = ResourceReference<EmailService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported CommunicationDomain resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-03-31.
        /// </summary>
        public static readonly string V2023_03_31 = "2023-03-31";
    }

    /// <summary>
    /// Creates a reference to an existing CommunicationDomain.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CommunicationDomain resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CommunicationDomain.</param>
    /// <returns>The existing CommunicationDomain resource.</returns>
    public static CommunicationDomain FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
