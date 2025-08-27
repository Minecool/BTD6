namespace Newtonsoft.Json.UnityConverters.Math;

public class Vector3IntConverter : PartialConverter<Vector3Int>
{

	public Vector3IntConverter() { }

	protected virtual void ReadValue(ref Vector3Int value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Vector3Int value, JsonSerializer serializer) { }

}

