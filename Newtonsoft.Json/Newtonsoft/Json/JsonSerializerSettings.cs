namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(2)]
public class JsonSerializerSettings
{
	internal const ReferenceLoopHandling DefaultReferenceLoopHandling = 0; //Field offset: 0x0
	internal const int DefaultMaxDepth = 64; //Field offset: 0x0
	[Nullable(1)]
	internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK"; //Field offset: 0x0
	internal const bool DefaultCheckAdditionalContent = False; //Field offset: 0x0
	internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = 0; //Field offset: 0x0
	internal const StringEscapeHandling DefaultStringEscapeHandling = 0; //Field offset: 0x0
	internal const FloatFormatHandling DefaultFloatFormatHandling = 0; //Field offset: 0x0
	internal const FloatParseHandling DefaultFloatParseHandling = 0; //Field offset: 0x0
	internal const DateParseHandling DefaultDateParseHandling = 1; //Field offset: 0x0
	internal const DateFormatHandling DefaultDateFormatHandling = 0; //Field offset: 0x0
	internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = 3; //Field offset: 0x0
	internal static readonly StreamingContext DefaultContext; //Field offset: 0x0
	internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = 0; //Field offset: 0x0
	internal const TypeNameHandling DefaultTypeNameHandling = 0; //Field offset: 0x0
	internal const ConstructorHandling DefaultConstructorHandling = 0; //Field offset: 0x0
	internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = 0; //Field offset: 0x0
	internal const ObjectCreationHandling DefaultObjectCreationHandling = 0; //Field offset: 0x0
	internal const DefaultValueHandling DefaultDefaultValueHandling = 0; //Field offset: 0x0
	internal const NullValueHandling DefaultNullValueHandling = 0; //Field offset: 0x0
	internal const MissingMemberHandling DefaultMissingMemberHandling = 0; //Field offset: 0x0
	internal const Formatting DefaultFormatting = 0; //Field offset: 0x0
	[Nullable(1)]
	internal static readonly CultureInfo DefaultCulture; //Field offset: 0x10
	internal Nullable<Formatting> _formatting; //Field offset: 0x10
	internal Nullable<DateFormatHandling> _dateFormatHandling; //Field offset: 0x18
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; //Field offset: 0x20
	internal Nullable<DateParseHandling> _dateParseHandling; //Field offset: 0x28
	internal Nullable<FloatFormatHandling> _floatFormatHandling; //Field offset: 0x30
	internal Nullable<FloatParseHandling> _floatParseHandling; //Field offset: 0x38
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; //Field offset: 0x40
	internal CultureInfo _culture; //Field offset: 0x48
	internal Nullable<Boolean> _checkAdditionalContent; //Field offset: 0x50
	internal Nullable<Int32> _maxDepth; //Field offset: 0x54
	internal bool _maxDepthSet; //Field offset: 0x5C
	internal string _dateFormatString; //Field offset: 0x60
	internal bool _dateFormatStringSet; //Field offset: 0x68
	internal Nullable<TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling; //Field offset: 0x6C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; //Field offset: 0x74
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; //Field offset: 0x7C
	internal Nullable<NullValueHandling> _nullValueHandling; //Field offset: 0x84
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; //Field offset: 0x8C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; //Field offset: 0x94
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; //Field offset: 0x9C
	internal Nullable<StreamingContext> _context; //Field offset: 0xA8
	internal Nullable<ConstructorHandling> _constructorHandling; //Field offset: 0xC0
	internal Nullable<TypeNameHandling> _typeNameHandling; //Field offset: 0xC8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; //Field offset: 0xD0
	[CompilerGenerated]
	[Nullable(1)]
	private IList<JsonConverter> <Converters>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private IContractResolver <ContractResolver>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private IEqualityComparer <EqualityComparer>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private ITraceWriter <TraceWriter>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private ISerializationBinder <SerializationBinder>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; //Field offset: 0x108

	public bool CheckAdditionalContent
	{
		 get { } //Length: 57
	}

	public ConstructorHandling ConstructorHandling
	{
		 get { } //Length: 61
	}

	public StreamingContext Context
	{
		 get { } //Length: 182
	}

	public IContractResolver ContractResolver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Nullable(1)]
	public IList<JsonConverter> Converters
	{
		[CompilerGenerated]
		[NullableContext(1)]
		 get { } //Length: 8
		[CompilerGenerated]
		[NullableContext(1)]
		 set { } //Length: 8
	}

	public DefaultValueHandling DefaultValueHandling
	{
		 get { } //Length: 55
		 set { } //Length: 91
	}

	public IEqualityComparer EqualityComparer
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public EventHandler<ErrorEventArgs> Error
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Formatting Formatting
	{
		 set { } //Length: 91
	}

	public MetadataPropertyHandling MetadataPropertyHandling
	{
		 get { } //Length: 61
	}

	public MissingMemberHandling MissingMemberHandling
	{
		 get { } //Length: 61
	}

	public NullValueHandling NullValueHandling
	{
		 get { } //Length: 61
	}

	public ObjectCreationHandling ObjectCreationHandling
	{
		 get { } //Length: 61
	}

	public PreserveReferencesHandling PreserveReferencesHandling
	{
		 get { } //Length: 61
	}

	public ReferenceLoopHandling ReferenceLoopHandling
	{
		 get { } //Length: 61
	}

	public Func<IReferenceResolver> ReferenceResolverProvider
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ISerializationBinder SerializationBinder
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public ITraceWriter TraceWriter
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
	{
		 get { } //Length: 55
	}

	public TypeNameHandling TypeNameHandling
	{
		 get { } //Length: 61
		 set { } //Length: 94
	}

	private static JsonSerializerSettings() { }

	[DebuggerStepThrough]
	public JsonSerializerSettings() { }

	public bool get_CheckAdditionalContent() { }

	public ConstructorHandling get_ConstructorHandling() { }

	public StreamingContext get_Context() { }

	[CompilerGenerated]
	public IContractResolver get_ContractResolver() { }

	[CompilerGenerated]
	[NullableContext(1)]
	public IList<JsonConverter> get_Converters() { }

	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGenerated]
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGenerated]
	public EventHandler<ErrorEventArgs> get_Error() { }

	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public MissingMemberHandling get_MissingMemberHandling() { }

	public NullValueHandling get_NullValueHandling() { }

	public ObjectCreationHandling get_ObjectCreationHandling() { }

	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	[CompilerGenerated]
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGenerated]
	public ISerializationBinder get_SerializationBinder() { }

	[CompilerGenerated]
	public ITraceWriter get_TraceWriter() { }

	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	public TypeNameHandling get_TypeNameHandling() { }

	[CompilerGenerated]
	public void set_ContractResolver(IContractResolver value) { }

	[CompilerGenerated]
	[NullableContext(1)]
	public void set_Converters(IList<JsonConverter> value) { }

	public void set_DefaultValueHandling(DefaultValueHandling value) { }

	[CompilerGenerated]
	public void set_Error(EventHandler<ErrorEventArgs> value) { }

	public void set_Formatting(Formatting value) { }

	public void set_TypeNameHandling(TypeNameHandling value) { }

}

