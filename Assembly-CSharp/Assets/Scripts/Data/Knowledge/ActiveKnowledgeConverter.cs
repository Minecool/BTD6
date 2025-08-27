namespace Assets.Scripts.Data.Knowledge;

public class ActiveKnowledgeConverter : JsonConverter
{

	public ActiveKnowledgeConverter() { }

	public virtual bool CanConvert(Type t) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

