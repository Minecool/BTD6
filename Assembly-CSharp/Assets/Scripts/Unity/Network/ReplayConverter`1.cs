namespace Assets.Scripts.Unity.Network;

public class ReplayConverter : JsonConverter
{

	public ReplayConverter`1() { }

	public virtual bool CanConvert(Type t) { }

	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

