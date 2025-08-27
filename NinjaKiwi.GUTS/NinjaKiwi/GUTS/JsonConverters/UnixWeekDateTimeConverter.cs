namespace NinjaKiwi.GUTS.JsonConverters;

public class UnixWeekDateTimeConverter : DateTimeConverterBase
{

	public UnixWeekDateTimeConverter() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

