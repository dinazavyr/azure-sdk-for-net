// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// Parameters of the search job that initiated this table.
/// </summary>
public partial class OperationalInsightsTableSearchResults : ProvisionableConstruct
{
    /// <summary>
    /// Search job query.
    /// </summary>
    public BicepValue<string> Query { get => _query; set => _query.Assign(value); }
    private readonly BicepValue<string> _query;

    /// <summary>
    /// Search job Description.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// Limit the search job to return up to specified number of rows.
    /// </summary>
    public BicepValue<int> Limit { get => _limit; set => _limit.Assign(value); }
    private readonly BicepValue<int> _limit;

    /// <summary>
    /// The timestamp to start the search from (UTC).
    /// </summary>
    public BicepValue<DateTimeOffset> StartSearchOn { get => _startSearchOn; set => _startSearchOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _startSearchOn;

    /// <summary>
    /// The timestamp to end the search by (UTC).
    /// </summary>
    public BicepValue<DateTimeOffset> EndSearchOn { get => _endSearchOn; set => _endSearchOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _endSearchOn;

    /// <summary>
    /// The table used in the search job.
    /// </summary>
    public BicepValue<string> SourceTable { get => _sourceTable; }
    private readonly BicepValue<string> _sourceTable;

    /// <summary>
    /// Search results table async operation id.
    /// </summary>
    public BicepValue<Guid> AzureAsyncOperationId { get => _azureAsyncOperationId; }
    private readonly BicepValue<Guid> _azureAsyncOperationId;

    /// <summary>
    /// Creates a new OperationalInsightsTableSearchResults.
    /// </summary>
    public OperationalInsightsTableSearchResults()
    {
        _query = BicepValue<string>.DefineProperty(this, "Query", ["query"]);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["description"]);
        _limit = BicepValue<int>.DefineProperty(this, "Limit", ["limit"]);
        _startSearchOn = BicepValue<DateTimeOffset>.DefineProperty(this, "StartSearchOn", ["startSearchTime"]);
        _endSearchOn = BicepValue<DateTimeOffset>.DefineProperty(this, "EndSearchOn", ["endSearchTime"]);
        _sourceTable = BicepValue<string>.DefineProperty(this, "SourceTable", ["sourceTable"], isOutput: true);
        _azureAsyncOperationId = BicepValue<Guid>.DefineProperty(this, "AzureAsyncOperationId", ["azureAsyncOperationId"], isOutput: true);
    }
}
