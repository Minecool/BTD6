namespace Assets.Scripts.Unity.JsonConverters;

public abstract class ClassCreationConverter : JsonConverter
{

	protected ClassCreationConverter`1() { }

	public virtual bool CanConvert(Type objectType) { }

	protected abstract T Create(Type objectType, JObject jObject) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

}

