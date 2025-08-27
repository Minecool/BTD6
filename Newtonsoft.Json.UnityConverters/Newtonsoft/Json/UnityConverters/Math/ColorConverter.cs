namespace Newtonsoft.Json.UnityConverters.Math;

public class ColorConverter : PartialConverter<Color>
{

	public ColorConverter() { }

	protected virtual void ReadValue(ref Color value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Color value, JsonSerializer serializer) { }

}

