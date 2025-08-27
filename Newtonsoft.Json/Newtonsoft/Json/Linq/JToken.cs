namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public abstract class JToken : IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider
{
	[NullableContext(0)]
	private class LineInfoAnnotation
	{
		internal readonly int LineNumber; //Field offset: 0x10
		internal readonly int LinePosition; //Field offset: 0x14

		public LineInfoAnnotation(int lineNumber, int linePosition) { }

	}

	[Nullable(2)]
	private static JTokenEqualityComparer _equalityComparer; //Field offset: 0x0
	private static readonly JTokenType[] BooleanTypes; //Field offset: 0x8
	private static readonly JTokenType[] NumberTypes; //Field offset: 0x10
	private static readonly JTokenType[] BigIntegerTypes; //Field offset: 0x18
	private static readonly JTokenType[] StringTypes; //Field offset: 0x20
	private static readonly JTokenType[] GuidTypes; //Field offset: 0x28
	private static readonly JTokenType[] TimeSpanTypes; //Field offset: 0x30
	private static readonly JTokenType[] UriTypes; //Field offset: 0x38
	private static readonly JTokenType[] CharTypes; //Field offset: 0x40
	private static readonly JTokenType[] DateTimeTypes; //Field offset: 0x48
	private static readonly JTokenType[] BytesTypes; //Field offset: 0x50
	[Nullable(2)]
	private JContainer _parent; //Field offset: 0x10
	[Nullable(2)]
	private JToken _previous; //Field offset: 0x18
	[Nullable(2)]
	private JToken _next; //Field offset: 0x20
	[Nullable(2)]
	private object _annotations; //Field offset: 0x28

	[Nullable(2)]
	public override JToken First
	{
		[NullableContext(2)]
		 get { } //Length: 148
	}

	public abstract bool HasValues
	{
		 get { } //Length: 0
	}

	[Nullable(2)]
	public override JToken Item
	{
		 get { } //Length: 148
	}

	[Nullable(2)]
	public override JToken Last
	{
		[NullableContext(2)]
		 get { } //Length: 148
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LineNumber
	{
		private get { } //Length: 72
	}

	private override int Newtonsoft.Json.IJsonLineInfo.LinePosition
	{
		private get { } //Length: 72
	}

	[Nullable(2)]
	public internal JToken Next
	{
		[NullableContext(2)]
		 get { } //Length: 5
		[NullableContext(2)]
		internal set { } //Length: 5
	}

	[Nullable(2)]
	public internal JContainer Parent
	{
		[DebuggerStepThrough]
		[NullableContext(2)]
		 get { } //Length: 5
		[NullableContext(2)]
		internal set { } //Length: 5
	}

	public string Path
	{
		 get { } //Length: 708
	}

	[Nullable(2)]
	public internal JToken Previous
	{
		[NullableContext(2)]
		 get { } //Length: 5
		[NullableContext(2)]
		internal set { } //Length: 5
	}

	public JToken Root
	{
		 get { } //Length: 33
	}

	public abstract JTokenType Type
	{
		 get { } //Length: 0
	}

	private static JToken() { }

	internal JToken() { }

	public void AddAnnotation(object annotation) { }

	public T Annotation() { }

	public override JEnumerable<JToken> Children() { }

	internal abstract JToken CloneToken(JsonCloneSettings settings) { }

	internal void CopyAnnotations(JToken target, JToken source) { }

	public JsonReader CreateReader() { }

	public JToken DeepClone() { }

	private static JValue EnsureValue(JToken value) { }

	public static JToken FromObject(object o) { }

	internal static JToken FromObjectInternal(object o, JsonSerializer jsonSerializer) { }

	[NullableContext(2)]
	public override JToken get_First() { }

	public abstract bool get_HasValues() { }

	public override JToken get_Item(object key) { }

	[NullableContext(2)]
	public override JToken get_Last() { }

	[NullableContext(2)]
	public JToken get_Next() { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public JContainer get_Parent() { }

	public string get_Path() { }

	[NullableContext(2)]
	public JToken get_Previous() { }

	public JToken get_Root() { }

	public abstract JTokenType get_Type() { }

	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	private static string GetType(JToken token) { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private override int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	private override bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	[CLSCompliant(False)]
	public static uint op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Int64> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Single> op_Explicit(JToken value) { }

	public static decimal op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	public static Nullable<UInt32> op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	public static Nullable<UInt64> op_Explicit(JToken value) { }

	public static double op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Guid> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static string op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	public static ulong op_Explicit(JToken value) { }

	public static Guid op_Explicit(JToken value) { }

	public static TimeSpan op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Uri op_Explicit(JToken value) { }

	public static float op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	public static Nullable<SByte> op_Explicit(JToken value) { }

	public static DateTime op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	[NullableContext(2)]
	public static Nullable<UInt16> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Byte> op_Explicit(JToken value) { }

	public static DateTimeOffset op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Boolean> op_Explicit(JToken value) { }

	public static long op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Double> op_Explicit(JToken value) { }

	public static bool op_Explicit(JToken value) { }

	public static int op_Explicit(JToken value) { }

	public static short op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	public static char op_Explicit(JToken value) { }

	public static byte op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	public static sbyte op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Int32> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Int16> op_Explicit(JToken value) { }

	[NullableContext(2)]
	public static Nullable<Char> op_Explicit(JToken value) { }

	public static JToken op_Implicit(string value) { }

	public static JToken op_Implicit(float value) { }

	[CLSCompliant(False)]
	public static JToken op_Implicit(uint value) { }

	public static JToken op_Implicit(bool value) { }

	public static JToken op_Implicit(int value) { }

	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	public static JToken ReadFrom(JsonReader reader) { }

	public void Remove() { }

	public void Replace(JToken value) { }

	[NullableContext(2)]
	internal void set_Next(JToken value) { }

	[NullableContext(2)]
	internal void set_Parent(JContainer value) { }

	[NullableContext(2)]
	internal void set_Previous(JToken value) { }

	internal void SetLineInfo(int lineNumber, int linePosition) { }

	[NullableContext(2)]
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	private override IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	private override object System.ICloneable.Clone() { }

	private static BigInteger ToBigInteger(JToken value) { }

	private static Nullable<BigInteger> ToBigIntegerNullable(JToken value) { }

	public object ToObject(Type objectType) { }

	[NullableContext(2)]
	public T ToObject() { }

	[NullableContext(2)]
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	public virtual string ToString() { }

	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	[NullableContext(2)]
	public override T Value(object key) { }

	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}

