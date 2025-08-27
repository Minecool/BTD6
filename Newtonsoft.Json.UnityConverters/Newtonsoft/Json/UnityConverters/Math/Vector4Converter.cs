namespace Newtonsoft.Json.UnityConverters.Math;

public class Vector4Converter : PartialConverter<Vector4>
{

	public Vector4Converter() { }

	protected virtual void ReadValue(ref Vector4 value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Vector4 value, JsonSerializer serializer) { }

}

