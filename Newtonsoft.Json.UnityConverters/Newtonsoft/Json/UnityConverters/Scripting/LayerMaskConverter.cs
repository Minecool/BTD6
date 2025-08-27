namespace Newtonsoft.Json.UnityConverters.Scripting;

public class LayerMaskConverter : JsonConverter
{

	public LayerMaskConverter() { }

	public virtual bool CanConvert(Type objectType) { }

	private static int GetInt(object value) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

