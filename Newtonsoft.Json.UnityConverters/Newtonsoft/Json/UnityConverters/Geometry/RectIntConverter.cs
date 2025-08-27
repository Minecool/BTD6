namespace Newtonsoft.Json.UnityConverters.Geometry;

public class RectIntConverter : PartialConverter<RectInt>
{

	public RectIntConverter() { }

	protected virtual void ReadValue(ref RectInt value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, RectInt value, JsonSerializer serializer) { }

}

