namespace Newtonsoft.Json.UnityConverters.Math;

public class Vector2Converter : PartialConverter<Vector2>
{

	public Vector2Converter() { }

	protected virtual void ReadValue(ref Vector2 value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Vector2 value, JsonSerializer serializer) { }

}

