namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
internal class JsonSerializerProxy : JsonSerializer
{
	[Nullable(2)]
	private readonly JsonSerializerInternalReader _serializerReader; //Field offset: 0xE0
	[Nullable(2)]
	private readonly JsonSerializerInternalWriter _serializerWriter; //Field offset: 0xE8
	internal readonly JsonSerializer _serializer; //Field offset: 0xF0

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public virtual event EventHandler<ErrorEventArgs> Error
	{
		 add { } //Length: 42
		 remove { } //Length: 42
	}

	public virtual bool CheckAdditionalContent
	{
		 get { } //Length: 45
		 set { } //Length: 42
	}

	public virtual ConstructorHandling ConstructorHandling
	{
		 set { } //Length: 42
	}

	public virtual StreamingContext Context
	{
		 get { } //Length: 65
		 set { } //Length: 55
	}

	public virtual IContractResolver ContractResolver
	{
		 get { } //Length: 45
		 set { } //Length: 42
	}

	public virtual JsonConverterCollection Converters
	{
		 get { } //Length: 45
	}

	public virtual DefaultValueHandling DefaultValueHandling
	{
		 set { } //Length: 42
	}

	[Nullable(2)]
	public virtual IEqualityComparer EqualityComparer
	{
		[NullableContext(2)]
		 set { } //Length: 42
	}

	public virtual Formatting Formatting
	{
		 get { } //Length: 45
		 set { } //Length: 42
	}

	public virtual Nullable<Int32> MaxDepth
	{
		 get { } //Length: 45
	}

	public virtual MetadataPropertyHandling MetadataPropertyHandling
	{
		 get { } //Length: 45
		 set { } //Length: 42
	}

	public virtual MissingMemberHandling MissingMemberHandling
	{
		 set { } //Length: 42
	}

	public virtual NullValueHandling NullValueHandling
	{
		 get { } //Length: 45
		 set { } //Length: 42
	}

	public virtual ObjectCreationHandling ObjectCreationHandling
	{
		 set { } //Length: 42
	}

	public virtual PreserveReferencesHandling PreserveReferencesHandling
	{
		 set { } //Length: 42
	}

	public virtual ReferenceLoopHandling ReferenceLoopHandling
	{
		 set { } //Length: 42
	}

	[Nullable(2)]
	public virtual IReferenceResolver ReferenceResolver
	{
		[NullableContext(2)]
		 set { } //Length: 42
	}

	public virtual ISerializationBinder SerializationBinder
	{
		 set { } //Length: 42
	}

	[Nullable(2)]
	public virtual ITraceWriter TraceWriter
	{
		[NullableContext(2)]
		 get { } //Length: 45
		[NullableContext(2)]
		 set { } //Length: 42
	}

	public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		 set { } //Length: 42
	}

	public virtual TypeNameHandling TypeNameHandling
	{
		 set { } //Length: 42
	}

	public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter) { }

	public JsonSerializerProxy(JsonSerializerInternalReader serializerReader) { }

	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	public virtual bool get_CheckAdditionalContent() { }

	public virtual StreamingContext get_Context() { }

	public virtual IContractResolver get_ContractResolver() { }

	public virtual JsonConverterCollection get_Converters() { }

	public virtual Formatting get_Formatting() { }

	public virtual Nullable<Int32> get_MaxDepth() { }

	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public virtual NullValueHandling get_NullValueHandling() { }

	[NullableContext(2)]
	public virtual ITraceWriter get_TraceWriter() { }

	internal JsonSerializerInternalBase GetInternalSerializer() { }

	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

	public virtual void set_CheckAdditionalContent(bool value) { }

	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	public virtual void set_Context(StreamingContext value) { }

	public virtual void set_ContractResolver(IContractResolver value) { }

	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	[NullableContext(2)]
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	public virtual void set_Formatting(Formatting value) { }

	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	public virtual void set_NullValueHandling(NullValueHandling value) { }

	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[NullableContext(2)]
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	[NullableContext(2)]
	public virtual void set_TraceWriter(ITraceWriter value) { }

	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

}

