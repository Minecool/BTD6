namespace Assets.Scripts.Utils;

public class Vector3ConverterSmall : JsonConverter
{
	private const char kSeparator = '\u2C'; //Field offset: 0x0
	private static StringBuilder _cachedStringBuilder; //Field offset: 0x0

	public Vector3ConverterSmall() { }

	public virtual bool CanConvert(Type objectType) { }

	private static float InvariantParseFloat(ReadOnlySpan<Char> stringSlice) { }

	private static float ReadAsFloat(JsonReader reader) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

