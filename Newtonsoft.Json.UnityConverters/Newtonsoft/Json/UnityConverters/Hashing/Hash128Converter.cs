namespace Newtonsoft.Json.UnityConverters.Hashing;

public class Hash128Converter : JsonConverter
{

	public Hash128Converter() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

