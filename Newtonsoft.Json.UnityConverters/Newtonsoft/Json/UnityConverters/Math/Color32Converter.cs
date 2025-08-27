namespace Newtonsoft.Json.UnityConverters.Math;

public class Color32Converter : PartialConverter<Color32>
{

	public Color32Converter() { }

	protected virtual void ReadValue(ref Color32 value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Color32 value, JsonSerializer serializer) { }

}

