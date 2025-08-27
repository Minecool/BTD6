namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
public class JsonReaderException : JsonException
{
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	[Nullable(2)]
	private readonly string <Path>k__BackingField; //Field offset: 0x98

	public JsonReaderException() { }

	public JsonReaderException(string message) { }

	public JsonReaderException(SerializationInfo info, StreamingContext context) { }

	public JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	internal static JsonReaderException Create(JsonReader reader, string message) { }

	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

