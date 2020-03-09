using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

using Google.Protobuf.Collections;

using Jsml.Enums;
using Jsml.ProtocolBuffers;

namespace Jsml.Loadables
{
    class LoadableElement : AbstractLoadable
    {
        public readonly XElement Dom;
        public readonly Element PbElement;

        public LoadableElement(string path) : base(path: path, type: typeof(JsonElement))
        {
            var json = (Json as JsonElement)
                ?? throw new Exception(message: "Failed to load JSON.");
            Dom = json.GetDom();
            PbElement = json.GetPbElement();
        }

        protected class JsonElement : AbstractLoadable.JsonObject
        {
            [JsonConverter(typeof(ElementAttributesConverter))]
            public RepeatedField<Element.Types.ElementAttribute>? Attributes { get; set; }
            public List<JsonElement>? Children { get; set; }
            public string Tag { get; set; } = "div";
            public string Text { get; set; } = String.Empty;

            public XElement GetDom()
            {
                var dom = new XElement(name: Tag, content: Text);
                dom.SetAttributeValue(name: "data-jsml", value: String.Empty);
                dom.SetAttributeValue(name: "data-jsml-id", value: Guid.NewGuid());
                if (Attributes != null)
                {
                    foreach (var attribute in Attributes)
                    {
                        dom.SetAttributeValue(name: attribute.Key, value: attribute.Value);
                    }
                }
                if (Children != null)
                {
                    foreach (var child in Children)
                    {
                        dom.Add(content: child.GetDom());
                    }
                }
                return dom;
            }

            public Element GetPbElement()
            {
                var pbElement = new Element { Tag = Tag, Text = Text };
                if (Attributes != null)
                {
                    foreach (var attribute in Attributes)
                    {
                        pbElement.Attributes.Add(new Element.Types.ElementAttribute {
                            Key = attribute.Key,
                            Value = attribute.Value
                        });
                    }
                }
                if (Children != null)
                {
                    foreach (var child in Children)
                    {
                        pbElement.Children.Add(child.GetPbElement());
                    }
                }
                return pbElement;
            }
        }

        public class ElementChildrenConverter : JsonConverter<RepeatedField<Element>>
        {
            public override bool CanConvert(Type objectType) => true;

            public override RepeatedField<Element> Read(
                ref Utf8JsonReader reader,
                Type typeToConvert,
                JsonSerializerOptions options
            )
            {
                if (reader.TokenType != JsonTokenType.StartArray)
                {
                    throw new JsonException();
                }
                var elements = new RepeatedField<Element>();
                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.EndArray)
                    {
                        return elements;
                    }
                    elements.Add(
                        JsonSerializer.Deserialize<LoadableElement>(ref reader, options).PbElement
                    );
                }
                throw new JsonException();
            }

            public override void Write(
                Utf8JsonWriter writer,
                RepeatedField<Element> elements,
                JsonSerializerOptions options
            )
            {
                writer.WriteStartArray();
                foreach (var element in elements)
                {
                    
                }
                writer.WriteEndArray();
            }
        }

        public class ElementAttributesConverter
            : JsonConverter<RepeatedField<Element.Types.ElementAttribute>>
        {
            public override bool CanConvert(Type objectType) => true;

            public override RepeatedField<Element.Types.ElementAttribute> Read(
                ref Utf8JsonReader reader,
                Type typeToConvert,
                JsonSerializerOptions options
            )
            {
                if (reader.TokenType != JsonTokenType.StartObject)
                {
                    throw new JsonException();
                }
                var attributes = new RepeatedField<Element.Types.ElementAttribute>();
                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.EndObject)
                    {
                        return attributes;
                    }
                    if (reader.TokenType != JsonTokenType.PropertyName)
                    {
                        throw new JsonException();
                    }
                    attributes.Add(new Element.Types.ElementAttribute {
                        Key = reader.GetString(),
                        Value = JsonSerializer.Deserialize<String>(ref reader, options)
                    });
                }
                throw new JsonException();
            }

            public override void Write(
                Utf8JsonWriter writer,
                RepeatedField<Element.Types.ElementAttribute> attributes,
                JsonSerializerOptions options
            )
            {
                writer.WriteStartObject();
                foreach (var attribute in attributes)
                {
                    writer.WritePropertyName(attribute.Key);
                    writer.WriteStringValue(attribute.Value);
                }
                writer.WriteEndObject();
            }
        }
    }
}
