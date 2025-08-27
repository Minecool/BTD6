namespace NinjaKiwi.Common;

public class StringDateConverter : DateTimeConverterBase
{

	public StringDateConverter() { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

