namespace Newtonsoft.Json.UnityConverters;

public abstract class PartialConverter : JsonConverter
{

	protected PartialConverter`1() { }

	public virtual bool CanConvert(Type objectType) { }

	private T InternalReadJson(JsonReader reader, JsonSerializer serializer, object existingValue) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	protected abstract void ReadValue(ref T value, string name, JsonReader reader, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	protected abstract void WriteJsonProperties(JsonWriter writer, T value, JsonSerializer serializer) { }

}

