namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonSerializer
{
	internal TypeNameHandling _typeNameHandling; //Field offset: 0x10
	internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; //Field offset: 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; //Field offset: 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; //Field offset: 0x1C
	internal MissingMemberHandling _missingMemberHandling; //Field offset: 0x20
	internal ObjectCreationHandling _objectCreationHandling; //Field offset: 0x24
	internal NullValueHandling _nullValueHandling; //Field offset: 0x28
	internal DefaultValueHandling _defaultValueHandling; //Field offset: 0x2C
	internal ConstructorHandling _constructorHandling; //Field offset: 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; //Field offset: 0x34
	[Nullable(2)]
	internal JsonConverterCollection _converters; //Field offset: 0x38
	internal IContractResolver _contractResolver; //Field offset: 0x40
	[Nullable(2)]
	internal ITraceWriter _traceWriter; //Field offset: 0x48
	[Nullable(2)]
	internal IEqualityComparer _equalityComparer; //Field offset: 0x50
	internal ISerializationBinder _serializationBinder; //Field offset: 0x58
	internal StreamingContext _context; //Field offset: 0x60
	[Nullable(2)]
	private IReferenceResolver _referenceResolver; //Field offset: 0x70
	private Nullable<Formatting> _formatting; //Field offset: 0x78
	private Nullable<DateFormatHandling> _dateFormatHandling; //Field offset: 0x80
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; //Field offset: 0x88
	private Nullable<DateParseHandling> _dateParseHandling; //Field offset: 0x90
	private Nullable<FloatFormatHandling> _floatFormatHandling; //Field offset: 0x98
	private Nullable<FloatParseHandling> _floatParseHandling; //Field offset: 0xA0
	private Nullable<StringEscapeHandling> _stringEscapeHandling; //Field offset: 0xA8
	private CultureInfo _culture; //Field offset: 0xB0
	private Nullable<Int32> _maxDepth; //Field offset: 0xB8
	private bool _maxDepthSet; //Field offset: 0xC0
	private Nullable<Boolean> _checkAdditionalContent; //Field offset: 0xC1
	[Nullable(2)]
	private string _dateFormatString; //Field offset: 0xC8
	private bool _dateFormatStringSet; //Field offset: 0xD0
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private EventHandler<ErrorEventArgs> Error; //Field offset: 0xD8

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event EventHandler<ErrorEventArgs> Error
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public override bool CheckAdditionalContent
	{
		 get { } //Length: 63
		 set { } //Length: 94
	}

	public override ConstructorHandling ConstructorHandling
	{
		 set { } //Length: 99
	}

	public override StreamingContext Context
	{
		 get { } //Length: 11
		 set { } //Length: 8
	}

	public override IContractResolver ContractResolver
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	public override JsonConverterCollection Converters
	{
		 get { } //Length: 135
	}

	public override DefaultValueHandling DefaultValueHandling
	{
		 set { } //Length: 99
	}

	[Nullable(2)]
	public override IEqualityComparer EqualityComparer
	{
		[NullableContext(2)]
		 set { } //Length: 5
	}

	public override Formatting Formatting
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public override Nullable<Int32> MaxDepth
	{
		 get { } //Length: 8
	}

	public override MetadataPropertyHandling MetadataPropertyHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override MissingMemberHandling MissingMemberHandling
	{
		 set { } //Length: 99
	}

	public override NullValueHandling NullValueHandling
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public override ObjectCreationHandling ObjectCreationHandling
	{
		 set { } //Length: 99
	}

	public override PreserveReferencesHandling PreserveReferencesHandling
	{
		 set { } //Length: 99
	}

	public override ReferenceLoopHandling ReferenceLoopHandling
	{
		 set { } //Length: 99
	}

	[Nullable(2)]
	public override IReferenceResolver ReferenceResolver
	{
		[NullableContext(2)]
		 set { } //Length: 128
	}

	public override ISerializationBinder SerializationBinder
	{
		 set { } //Length: 128
	}

	[Nullable(2)]
	public override ITraceWriter TraceWriter
	{
		[NullableContext(2)]
		 get { } //Length: 5
		[NullableContext(2)]
		 set { } //Length: 5
	}

	public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		 set { } //Length: 99
	}

	public override TypeNameHandling TypeNameHandling
	{
		 set { } //Length: 99
	}

	public JsonSerializer() { }

	[CompilerGenerated]
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	public static JsonSerializer Create() { }

	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	public static JsonSerializer CreateDefault() { }

	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public object Deserialize(JsonReader reader, Type objectType) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public T Deserialize(JsonReader reader) { }

	[NullableContext(2)]
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	public override bool get_CheckAdditionalContent() { }

	public override StreamingContext get_Context() { }

	public override IContractResolver get_ContractResolver() { }

	public override JsonConverterCollection get_Converters() { }

	public override Formatting get_Formatting() { }

	public override Nullable<Int32> get_MaxDepth() { }

	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public override NullValueHandling get_NullValueHandling() { }

	[NullableContext(2)]
	public override ITraceWriter get_TraceWriter() { }

	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	internal JsonConverter GetMatchingConverter(Type type) { }

	internal IReferenceResolver GetReferenceResolver() { }

	internal bool IsCheckAdditionalContentSet() { }

	internal void OnError(ErrorEventArgs e) { }

	[DebuggerStepThrough]
	public void Populate(JsonReader reader, object target) { }

	internal override void PopulateInternal(JsonReader reader, object target) { }

	[CompilerGenerated]
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<Int32> previousMaxDepth, string previousDateFormatString) { }

	public void Serialize(JsonWriter jsonWriter, object value) { }

	[NullableContext(2)]
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	[NullableContext(2)]
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	public override void set_CheckAdditionalContent(bool value) { }

	public override void set_ConstructorHandling(ConstructorHandling value) { }

	public override void set_Context(StreamingContext value) { }

	public override void set_ContractResolver(IContractResolver value) { }

	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	[NullableContext(2)]
	public override void set_EqualityComparer(IEqualityComparer value) { }

	public override void set_Formatting(Formatting value) { }

	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	public override void set_NullValueHandling(NullValueHandling value) { }

	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	[NullableContext(2)]
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	public override void set_SerializationBinder(ISerializationBinder value) { }

	[NullableContext(2)]
	public override void set_TraceWriter(ITraceWriter value) { }

	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	public override void set_TypeNameHandling(TypeNameHandling value) { }

	[NullableContext(2)]
	internal void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling>& previousDateTimeZoneHandling, out Nullable<DateParseHandling>& previousDateParseHandling, out Nullable<FloatParseHandling>& previousFloatParseHandling, out Nullable<Int32>& previousMaxDepth, out string previousDateFormatString) { }

}

