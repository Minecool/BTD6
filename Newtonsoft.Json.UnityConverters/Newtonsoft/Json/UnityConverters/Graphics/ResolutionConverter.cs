namespace Newtonsoft.Json.UnityConverters.Graphics;

public class ResolutionConverter : PartialConverter<Resolution>
{

	public ResolutionConverter() { }

	protected virtual void ReadValue(ref Resolution value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Resolution value, JsonSerializer serializer) { }

}

