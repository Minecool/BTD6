namespace Newtonsoft.Json.UnityConverters.NativeArray;

public class NativeArrayConverter : JsonConverter
{

	public NativeArrayConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

