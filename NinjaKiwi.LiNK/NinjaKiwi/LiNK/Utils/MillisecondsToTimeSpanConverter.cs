namespace NinjaKiwi.LiNK.Utils;

public class MillisecondsToTimeSpanConverter : JsonConverter
{

	public MillisecondsToTimeSpanConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

