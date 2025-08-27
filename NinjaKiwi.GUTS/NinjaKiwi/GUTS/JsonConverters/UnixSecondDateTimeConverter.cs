namespace NinjaKiwi.GUTS.JsonConverters;

public class UnixSecondDateTimeConverter : DateTimeConverterBase
{

	public UnixSecondDateTimeConverter() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

