namespace Newtonsoft.Json.UnityConverters.Geometry;

public class BoundsIntConverter : PartialConverter<BoundsInt>
{

	public BoundsIntConverter() { }

	protected virtual void ReadValue(ref BoundsInt value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, BoundsInt value, JsonSerializer serializer) { }

}

