// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class FieldRestrictions : IUtf8JsonSerializable, IJsonModel<FieldRestrictions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FieldRestrictions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FieldRestrictions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FieldRestrictions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FieldRestrictions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Field))
            {
                writer.WritePropertyName("field"u8);
                writer.WriteStringValue(Field);
            }
            if (Optional.IsCollectionDefined(Restrictions))
            {
                writer.WritePropertyName("restrictions"u8);
                writer.WriteStartArray();
                foreach (var item in Restrictions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        FieldRestrictions IJsonModel<FieldRestrictions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FieldRestrictions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FieldRestrictions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFieldRestrictions(document.RootElement, options);
        }

        internal static FieldRestrictions DeserializeFieldRestrictions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> field = default;
            Optional<IReadOnlyList<FieldRestriction>> restrictions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field"u8))
                {
                    field = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FieldRestriction> array = new List<FieldRestriction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FieldRestriction.DeserializeFieldRestriction(item));
                    }
                    restrictions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FieldRestrictions(field.Value, Optional.ToList(restrictions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FieldRestrictions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FieldRestrictions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FieldRestrictions)} does not support '{options.Format}' format.");
            }
        }

        FieldRestrictions IPersistableModel<FieldRestrictions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FieldRestrictions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFieldRestrictions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FieldRestrictions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FieldRestrictions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
