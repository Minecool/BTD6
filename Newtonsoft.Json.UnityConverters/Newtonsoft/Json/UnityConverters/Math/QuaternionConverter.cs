namespace Newtonsoft.Json.UnityConverters.Math;

public class QuaternionConverter : PartialConverter<Quaternion>
{

	public QuaternionConverter() { }

	protected virtual void ReadValue(ref Quaternion value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Quaternion value, JsonSerializer serializer) { }

}

