namespace Assets.Twitch.JsonConverters;

public class TimeSpanSecondsConverter : JsonConverter
{

	public TimeSpanSecondsConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

