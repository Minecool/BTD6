namespace Newtonsoft.Json.UnityConverters.Helpers;

[Extension]
internal static class JsonHelperExtensions
{
	internal static readonly ConstructorInfo _JsonSerializationExceptionPositionalCtor; //Field offset: 0x0

	private static JsonHelperExtensions() { }

	[Extension]
	public static JsonSerializationException CreateSerializationException(JsonReader reader, string message, Exception innerException = null) { }

	private static StringBuilder CreateStringBuilderWithSpaceAfter(string message) { }

	[Extension]
	public static JsonWriterException CreateWriterException(JsonWriter writer, string message, Exception innerException = null) { }

	private static JsonSerializationException NewJsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	[Extension]
	public static Nullable<Single> ReadAsFloat(JsonReader reader) { }

	[Extension]
	public static Nullable<Byte> ReadAsInt8(JsonReader reader) { }

	[Extension]
	public static T ReadViaSerializer(JsonReader reader, JsonSerializer serializer) { }

}

