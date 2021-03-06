// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: element.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Jsml.ProtocolBuffers {

  /// <summary>Holder for reflection information generated from element.proto</summary>
  public static partial class ElementReflection {

    #region Descriptor
    /// <summary>File descriptor for element.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ElementReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1lbGVtZW50LnByb3RvEhRKc21sLlByb3RvY29sQnVmZmVycyLJAQoHRWxl",
            "bWVudBJCCgphdHRyaWJ1dGVzGAEgAygLMi4uSnNtbC5Qcm90b2NvbEJ1ZmZl",
            "cnMuRWxlbWVudC5FbGVtZW50QXR0cmlidXRlEi8KCGNoaWxkcmVuGAIgAygL",
            "Mh0uSnNtbC5Qcm90b2NvbEJ1ZmZlcnMuRWxlbWVudBILCgN0YWcYAyABKAkS",
            "DAoEdGV4dBgEIAEoCRouChBFbGVtZW50QXR0cmlidXRlEgsKA2tleRgBIAEo",
            "CRINCgV2YWx1ZRgCIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Jsml.ProtocolBuffers.Element), global::Jsml.ProtocolBuffers.Element.Parser, new[]{ "Attributes", "Children", "Tag", "Text" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Jsml.ProtocolBuffers.Element.Types.ElementAttribute), global::Jsml.ProtocolBuffers.Element.Types.ElementAttribute.Parser, new[]{ "Key", "Value" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Element : pb::IMessage<Element> {
    private static readonly pb::MessageParser<Element> _parser = new pb::MessageParser<Element>(() => new Element());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Element> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Jsml.ProtocolBuffers.ElementReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Element() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Element(Element other) : this() {
      attributes_ = other.attributes_.Clone();
      children_ = other.children_.Clone();
      tag_ = other.tag_;
      text_ = other.text_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Element Clone() {
      return new Element(this);
    }

    /// <summary>Field number for the "attributes" field.</summary>
    public const int AttributesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Jsml.ProtocolBuffers.Element.Types.ElementAttribute> _repeated_attributes_codec
        = pb::FieldCodec.ForMessage(10, global::Jsml.ProtocolBuffers.Element.Types.ElementAttribute.Parser);
    private readonly pbc::RepeatedField<global::Jsml.ProtocolBuffers.Element.Types.ElementAttribute> attributes_ = new pbc::RepeatedField<global::Jsml.ProtocolBuffers.Element.Types.ElementAttribute>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Jsml.ProtocolBuffers.Element.Types.ElementAttribute> Attributes {
      get { return attributes_; }
    }

    /// <summary>Field number for the "children" field.</summary>
    public const int ChildrenFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Jsml.ProtocolBuffers.Element> _repeated_children_codec
        = pb::FieldCodec.ForMessage(18, global::Jsml.ProtocolBuffers.Element.Parser);
    private readonly pbc::RepeatedField<global::Jsml.ProtocolBuffers.Element> children_ = new pbc::RepeatedField<global::Jsml.ProtocolBuffers.Element>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Jsml.ProtocolBuffers.Element> Children {
      get { return children_; }
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 3;
    private string tag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 4;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Element);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Element other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!attributes_.Equals(other.attributes_)) return false;
      if(!children_.Equals(other.children_)) return false;
      if (Tag != other.Tag) return false;
      if (Text != other.Text) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= attributes_.GetHashCode();
      hash ^= children_.GetHashCode();
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      attributes_.WriteTo(output, _repeated_attributes_codec);
      children_.WriteTo(output, _repeated_children_codec);
      if (Tag.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Tag);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Text);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += attributes_.CalculateSize(_repeated_attributes_codec);
      size += children_.CalculateSize(_repeated_children_codec);
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Element other) {
      if (other == null) {
        return;
      }
      attributes_.Add(other.attributes_);
      children_.Add(other.children_);
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            attributes_.AddEntriesFrom(input, _repeated_attributes_codec);
            break;
          }
          case 18: {
            children_.AddEntriesFrom(input, _repeated_children_codec);
            break;
          }
          case 26: {
            Tag = input.ReadString();
            break;
          }
          case 34: {
            Text = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Element message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class ElementAttribute : pb::IMessage<ElementAttribute> {
        private static readonly pb::MessageParser<ElementAttribute> _parser = new pb::MessageParser<ElementAttribute>(() => new ElementAttribute());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ElementAttribute> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Jsml.ProtocolBuffers.Element.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ElementAttribute() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ElementAttribute(ElementAttribute other) : this() {
          key_ = other.key_;
          value_ = other.value_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ElementAttribute Clone() {
          return new ElementAttribute(this);
        }

        /// <summary>Field number for the "key" field.</summary>
        public const int KeyFieldNumber = 1;
        private string key_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Key {
          get { return key_; }
          set {
            key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 2;
        private string value_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Value {
          get { return value_; }
          set {
            value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ElementAttribute);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ElementAttribute other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Key != other.Key) return false;
          if (Value != other.Value) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Key.Length != 0) hash ^= Key.GetHashCode();
          if (Value.Length != 0) hash ^= Value.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Key.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Key);
          }
          if (Value.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Value);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Key.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
          }
          if (Value.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ElementAttribute other) {
          if (other == null) {
            return;
          }
          if (other.Key.Length != 0) {
            Key = other.Key;
          }
          if (other.Value.Length != 0) {
            Value = other.Value;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                Key = input.ReadString();
                break;
              }
              case 18: {
                Value = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
