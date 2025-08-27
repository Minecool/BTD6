namespace Newtonsoft.Json.UnityConverters.Geometry;

public class RectOffsetConverter : PartialConverter<RectOffset>
{

	public RectOffsetConverter() { }

	protected virtual void ReadValue(ref RectOffset value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, RectOffset value, JsonSerializer serializer) { }

}

