namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public static class JsonConvert
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; //Field offset: 0x0
	public static readonly string True; //Field offset: 0x8
	public static readonly string False; //Field offset: 0x10
	public static readonly string Null; //Field offset: 0x18
	public static readonly string Undefined; //Field offset: 0x20
	public static readonly string PositiveInfinity; //Field offset: 0x28
	public static readonly string NegativeInfinity; //Field offset: 0x30
	public static readonly string NaN; //Field offset: 0x38

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public static Func<JsonSerializerSettings> DefaultSettings
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		 set { } //Length: 84
	}

	private static JsonConvert() { }

	[DebuggerStepThrough]
	public static T DeserializeAnonymousType(string value, T anonymousTypeObject, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	public static T DeserializeAnonymousType(string value, T anonymousTypeObject) { }

	[NullableContext(2)]
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static T DeserializeObject(string value, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static T DeserializeObject(string value) { }

	[DebuggerStepThrough]
	public static object DeserializeObject(string value, Type type) { }

	private static string EnsureDecimalPlace(double value, string text) { }

	private static string EnsureDecimalPlace(string text) { }

	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	[CompilerGenerated]
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[DebuggerStepThrough]
	public static void PopulateObject(string value, object target) { }

	public static void PopulateObject(string value, object target, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	public static string SerializeObject(object value, Formatting formatting) { }

	[DebuggerStepThrough]
	public static string SerializeObject(object value) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	[NullableContext(2)]
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	[CompilerGenerated]
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	public static string ToString(decimal value) { }

	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	public static string ToString(char value) { }

	public static string ToString(bool value) { }

	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	public static string ToString(string value) { }

	public static string ToString(string value, char delimiter) { }

}

