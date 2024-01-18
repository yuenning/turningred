// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/contract/hello_world_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.HelloWorld {

  /// <summary>Holder for reflection information generated from Protobuf/contract/hello_world_contract.proto</summary>
  public static partial class HelloWorldContractReflection {

    #region Descriptor
    /// <summary>File descriptor for Protobuf/contract/hello_world_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HelloWorldContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixQcm90b2J1Zi9jb250cmFjdC9oZWxsb193b3JsZF9jb250cmFjdC5wcm90",
            "bxoPYWVsZi9jb3JlLnByb3RvGhJhZWxmL29wdGlvbnMucHJvdG8aG2dvb2ds",
            "ZS9wcm90b2J1Zi9lbXB0eS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBw",
            "ZXJzLnByb3RvGh5Qcm90b2J1Zi9yZWZlcmVuY2UvYWNzMTIucHJvdG8iVwoS",
            "U0NUcmFuc2FjdGlvbklucHV0EhEKCXJlY2lwaWVudBgBIAEoCRIMCgRpdGVt",
            "GAIgASgJEhAKCHF1YW50aXR5GAMgASgFEg4KBmFtb3VudBgEIAEoBSJ1ChFT",
            "Q1RyYW5zYWN0aW9uRGF0YRIdCgZzZW5kZXIYASABKAsyDS5hZWxmLkFkZHJl",
            "c3MSEQoJcmVjaXBpZW50GAIgASgJEgwKBGl0ZW0YAyABKAkSEAoIcXVhbnRp",
            "dHkYBCABKAUSDgoGYW1vdW50GAUgASgFMp8CCgpIZWxsb1dvcmxkEjwKCklu",
            "aXRpYWxpemUSFi5nb29nbGUucHJvdG9idWYuRW1wdHkaFi5nb29nbGUucHJv",
            "dG9idWYuRW1wdHkSQgoTQ3JlYXRlU0NUcmFuc2FjdGlvbhITLlNDVHJhbnNh",
            "Y3Rpb25JbnB1dBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRI8ChBHZXRTQ1Ry",
            "YW5zYWN0aW9uEg0uYWVsZi5BZGRyZXNzGhIuU0NUcmFuc2FjdGlvbkRhdGEi",
            "BYiJ9wEBGlGyzPYBKUFFbGYuQ29udHJhY3RzLkhlbGxvV29ybGQuSGVsbG9X",
            "b3JsZFN0YXRlysr2AR5Qcm90b2J1Zi9yZWZlcmVuY2UvYWNzMTIucHJvdG9C",
            "HKoCGUFFbGYuQ29udHJhY3RzLkhlbGxvV29ybGRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Types.CoreReflection.Descriptor, global::AElf.OptionsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::AElf.Standards.ACS12.Acs12Reflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.HelloWorld.SCTransactionInput), global::AElf.Contracts.HelloWorld.SCTransactionInput.Parser, new[]{ "Recipient", "Item", "Quantity", "Amount" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.HelloWorld.SCTransactionData), global::AElf.Contracts.HelloWorld.SCTransactionData.Parser, new[]{ "Sender", "Recipient", "Item", "Quantity", "Amount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SCTransactionInput : pb::IMessage<SCTransactionInput>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SCTransactionInput> _parser = new pb::MessageParser<SCTransactionInput>(() => new SCTransactionInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SCTransactionInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.HelloWorld.HelloWorldContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SCTransactionInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SCTransactionInput(SCTransactionInput other) : this() {
      recipient_ = other.recipient_;
      item_ = other.item_;
      quantity_ = other.quantity_;
      amount_ = other.amount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SCTransactionInput Clone() {
      return new SCTransactionInput(this);
    }

    /// <summary>Field number for the "recipient" field.</summary>
    public const int RecipientFieldNumber = 1;
    private string recipient_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Recipient {
      get { return recipient_; }
      set {
        recipient_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 2;
    private string item_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Item {
      get { return item_; }
      set {
        item_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 3;
    private int quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 4;
    private int amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SCTransactionInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SCTransactionInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Recipient != other.Recipient) return false;
      if (Item != other.Item) return false;
      if (Quantity != other.Quantity) return false;
      if (Amount != other.Amount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Recipient.Length != 0) hash ^= Recipient.GetHashCode();
      if (Item.Length != 0) hash ^= Item.GetHashCode();
      if (Quantity != 0) hash ^= Quantity.GetHashCode();
      if (Amount != 0) hash ^= Amount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Recipient.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Recipient);
      }
      if (Item.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Item);
      }
      if (Quantity != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Quantity);
      }
      if (Amount != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Amount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Recipient.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Recipient);
      }
      if (Item.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Item);
      }
      if (Quantity != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Quantity);
      }
      if (Amount != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Amount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Recipient.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Recipient);
      }
      if (Item.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Item);
      }
      if (Quantity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantity);
      }
      if (Amount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SCTransactionInput other) {
      if (other == null) {
        return;
      }
      if (other.Recipient.Length != 0) {
        Recipient = other.Recipient;
      }
      if (other.Item.Length != 0) {
        Item = other.Item;
      }
      if (other.Quantity != 0) {
        Quantity = other.Quantity;
      }
      if (other.Amount != 0) {
        Amount = other.Amount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Recipient = input.ReadString();
            break;
          }
          case 18: {
            Item = input.ReadString();
            break;
          }
          case 24: {
            Quantity = input.ReadInt32();
            break;
          }
          case 32: {
            Amount = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Recipient = input.ReadString();
            break;
          }
          case 18: {
            Item = input.ReadString();
            break;
          }
          case 24: {
            Quantity = input.ReadInt32();
            break;
          }
          case 32: {
            Amount = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SCTransactionData : pb::IMessage<SCTransactionData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SCTransactionData> _parser = new pb::MessageParser<SCTransactionData>(() => new SCTransactionData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SCTransactionData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.HelloWorld.HelloWorldContractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SCTransactionData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SCTransactionData(SCTransactionData other) : this() {
      sender_ = other.sender_ != null ? other.sender_.Clone() : null;
      recipient_ = other.recipient_;
      item_ = other.item_;
      quantity_ = other.quantity_;
      amount_ = other.amount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SCTransactionData Clone() {
      return new SCTransactionData(this);
    }

    /// <summary>Field number for the "sender" field.</summary>
    public const int SenderFieldNumber = 1;
    private global::AElf.Types.Address sender_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::AElf.Types.Address Sender {
      get { return sender_; }
      set {
        sender_ = value;
      }
    }

    /// <summary>Field number for the "recipient" field.</summary>
    public const int RecipientFieldNumber = 2;
    private string recipient_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Recipient {
      get { return recipient_; }
      set {
        recipient_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 3;
    private string item_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Item {
      get { return item_; }
      set {
        item_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 4;
    private int quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 5;
    private int amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SCTransactionData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SCTransactionData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Sender, other.Sender)) return false;
      if (Recipient != other.Recipient) return false;
      if (Item != other.Item) return false;
      if (Quantity != other.Quantity) return false;
      if (Amount != other.Amount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (sender_ != null) hash ^= Sender.GetHashCode();
      if (Recipient.Length != 0) hash ^= Recipient.GetHashCode();
      if (Item.Length != 0) hash ^= Item.GetHashCode();
      if (Quantity != 0) hash ^= Quantity.GetHashCode();
      if (Amount != 0) hash ^= Amount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (sender_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Sender);
      }
      if (Recipient.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Recipient);
      }
      if (Item.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Item);
      }
      if (Quantity != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Quantity);
      }
      if (Amount != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Amount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (sender_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Sender);
      }
      if (Recipient.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Recipient);
      }
      if (Item.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Item);
      }
      if (Quantity != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Quantity);
      }
      if (Amount != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Amount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (sender_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Sender);
      }
      if (Recipient.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Recipient);
      }
      if (Item.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Item);
      }
      if (Quantity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantity);
      }
      if (Amount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SCTransactionData other) {
      if (other == null) {
        return;
      }
      if (other.sender_ != null) {
        if (sender_ == null) {
          Sender = new global::AElf.Types.Address();
        }
        Sender.MergeFrom(other.Sender);
      }
      if (other.Recipient.Length != 0) {
        Recipient = other.Recipient;
      }
      if (other.Item.Length != 0) {
        Item = other.Item;
      }
      if (other.Quantity != 0) {
        Quantity = other.Quantity;
      }
      if (other.Amount != 0) {
        Amount = other.Amount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (sender_ == null) {
              Sender = new global::AElf.Types.Address();
            }
            input.ReadMessage(Sender);
            break;
          }
          case 18: {
            Recipient = input.ReadString();
            break;
          }
          case 26: {
            Item = input.ReadString();
            break;
          }
          case 32: {
            Quantity = input.ReadInt32();
            break;
          }
          case 40: {
            Amount = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (sender_ == null) {
              Sender = new global::AElf.Types.Address();
            }
            input.ReadMessage(Sender);
            break;
          }
          case 18: {
            Recipient = input.ReadString();
            break;
          }
          case 26: {
            Item = input.ReadString();
            break;
          }
          case 32: {
            Quantity = input.ReadInt32();
            break;
          }
          case 40: {
            Amount = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
