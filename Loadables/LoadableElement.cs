using System;
using System.Collections.Generic;
using System.Xml.Linq;

using Jsml.Enums;

namespace Jsml.Loadables
{
    class LoadableElement : AbstractLoadable
    {
        public readonly XElement Dom;
        
        public LoadableElement(string path) : base(path: path, type: typeof(JsonElement))
        {
            var json = (Json as JsonElement)
                ?? throw new Exception(message: "Failed to load JSON.");
            Dom = json.GetDom();
        }
        
        protected class JsonElement : AbstractLoadable.JsonObject
        {
            public string Tag { get; set; } = "div";
            public List<JsonElement>? Children { get; set; }
            public Dictionary<string, string>? Attributes { get; set; }
            
            public XElement GetDom()
            {
                var dom = new XElement(name: Tag);
                if (Attributes != null)
                {
                    foreach (var attribute in Attributes)
                    {
                        if (
                            Tag.ToLower() == Tags.Span.ToString().ToLower()
                            && attribute.Key.ToLower() == "value"
                        )
                        {
                            dom.SetValue(value: attribute.Value);
                            continue;
                        }
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
        }
    }
}
