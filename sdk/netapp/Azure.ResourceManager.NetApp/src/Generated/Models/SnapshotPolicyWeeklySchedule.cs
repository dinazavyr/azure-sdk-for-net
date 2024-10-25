// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Weekly Schedule properties, make a snapshot every week at a specific day or days
    /// Serialized Name: WeeklySchedule
    /// </summary>
    public partial class SnapshotPolicyWeeklySchedule
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyWeeklySchedule"/>. </summary>
        public SnapshotPolicyWeeklySchedule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyWeeklySchedule"/>. </summary>
        /// <param name="snapshotsToKeep">
        /// Weekly snapshot count to keep
        /// Serialized Name: WeeklySchedule.snapshotsToKeep
        /// </param>
        /// <param name="day">
        /// Indicates which weekdays snapshot should be taken, accepts a comma separated list of week day names in english
        /// Serialized Name: WeeklySchedule.day
        /// </param>
        /// <param name="hour">
        /// Indicates which hour in UTC timezone a snapshot should be taken
        /// Serialized Name: WeeklySchedule.hour
        /// </param>
        /// <param name="minute">
        /// Indicates which minute snapshot should be taken
        /// Serialized Name: WeeklySchedule.minute
        /// </param>
        /// <param name="usedBytes">
        /// Resource size in bytes, current storage usage for the volume in bytes
        /// Serialized Name: WeeklySchedule.usedBytes
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotPolicyWeeklySchedule(int? snapshotsToKeep, string day, int? hour, int? minute, long? usedBytes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SnapshotsToKeep = snapshotsToKeep;
            Day = day;
            Hour = hour;
            Minute = minute;
            UsedBytes = usedBytes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Weekly snapshot count to keep
        /// Serialized Name: WeeklySchedule.snapshotsToKeep
        /// </summary>
        public int? SnapshotsToKeep { get; set; }
        /// <summary>
        /// Indicates which weekdays snapshot should be taken, accepts a comma separated list of week day names in english
        /// Serialized Name: WeeklySchedule.day
        /// </summary>
        public string Day { get; set; }
        /// <summary>
        /// Indicates which hour in UTC timezone a snapshot should be taken
        /// Serialized Name: WeeklySchedule.hour
        /// </summary>
        public int? Hour { get; set; }
        /// <summary>
        /// Indicates which minute snapshot should be taken
        /// Serialized Name: WeeklySchedule.minute
        /// </summary>
        public int? Minute { get; set; }
        /// <summary>
        /// Resource size in bytes, current storage usage for the volume in bytes
        /// Serialized Name: WeeklySchedule.usedBytes
        /// </summary>
        public long? UsedBytes { get; set; }
    }
}
