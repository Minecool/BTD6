namespace NinjaKiwi.GUTS.Models.ContentBrowser;

public class AvailabilityScoreConverter : JsonConverter
{

	public AvailabilityScoreConverter() { }

	public virtual bool CanConvert(Type t) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

