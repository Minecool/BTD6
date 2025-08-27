namespace Newtonsoft.Json.UnityConverters.Geometry;

public class BoundsConverter : PartialConverter<Bounds>
{

	public BoundsConverter() { }

	protected virtual void ReadValue(ref Bounds value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Bounds value, JsonSerializer serializer) { }

}

