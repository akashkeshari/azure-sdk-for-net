// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class OcrSkill : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (TextExtractionAlgorithm != null)
            {
                writer.WritePropertyName("textExtractionAlgorithm");
                writer.WriteStringValue(TextExtractionAlgorithm.Value.ToSerialString());
            }
            if (DefaultLanguageCode != null)
            {
                writer.WritePropertyName("defaultLanguageCode");
                writer.WriteStringValue(DefaultLanguageCode.Value.ToString());
            }
            if (ShouldDetectOrientation != null)
            {
                writer.WritePropertyName("detectOrientation");
                writer.WriteBooleanValue(ShouldDetectOrientation.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Context != null)
            {
                writer.WritePropertyName("context");
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs");
            writer.WriteStartArray();
            foreach (var item0 in Outputs)
            {
                writer.WriteObjectValue(item0);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static OcrSkill DeserializeOcrSkill(JsonElement element)
        {
            TextExtractionAlgorithm? textExtractionAlgorithm = default;
            OcrSkillLanguage? defaultLanguageCode = default;
            bool? detectOrientation = default;
            string odatatype = default;
            string name = default;
            string description = default;
            string context = default;
            IList<InputFieldMappingEntry> inputs = new List<InputFieldMappingEntry>();
            IList<OutputFieldMappingEntry> outputs = new List<OutputFieldMappingEntry>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("textExtractionAlgorithm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    textExtractionAlgorithm = property.Value.GetString().ToTextExtractionAlgorithm();
                    continue;
                }
                if (property.NameEquals("defaultLanguageCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultLanguageCode = new OcrSkillLanguage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("detectOrientation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectOrientation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odatatype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
            }
            return new OcrSkill(textExtractionAlgorithm, defaultLanguageCode, detectOrientation, odatatype, name, description, context, inputs, outputs);
        }
    }
}
