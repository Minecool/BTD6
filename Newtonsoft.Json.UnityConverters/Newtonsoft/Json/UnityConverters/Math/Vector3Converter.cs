namespace Newtonsoft.Json.UnityConverters.Math;

public class Vector3Converter : PartialConverter<Vector3>
{

	public Vector3Converter() { }

	protected virtual void ReadValue(ref Vector3 value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Vector3 value, JsonSerializer serializer) { }

}

