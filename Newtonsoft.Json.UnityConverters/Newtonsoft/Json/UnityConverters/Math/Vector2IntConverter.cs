namespace Newtonsoft.Json.UnityConverters.Math;

public class Vector2IntConverter : PartialConverter<Vector2Int>
{

	public Vector2IntConverter() { }

	protected virtual void ReadValue(ref Vector2Int value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Vector2Int value, JsonSerializer serializer) { }

}

