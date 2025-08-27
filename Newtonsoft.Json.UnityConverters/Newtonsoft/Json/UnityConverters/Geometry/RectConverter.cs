namespace Newtonsoft.Json.UnityConverters.Geometry;

public class RectConverter : PartialConverter<Rect>
{

	public RectConverter() { }

	protected virtual void ReadValue(ref Rect value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Rect value, JsonSerializer serializer) { }

}

