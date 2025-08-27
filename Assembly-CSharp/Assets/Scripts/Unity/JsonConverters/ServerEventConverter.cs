namespace Assets.Scripts.Unity.JsonConverters;

public class ServerEventConverter : ClassCreationConverter<BaseServerEvent>
{

	public ServerEventConverter() { }

	protected virtual BaseServerEvent Create(Type objectType, JObject jObject) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

