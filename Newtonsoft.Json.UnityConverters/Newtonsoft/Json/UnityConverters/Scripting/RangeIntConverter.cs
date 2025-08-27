namespace Newtonsoft.Json.UnityConverters.Scripting;

public class RangeIntConverter : PartialConverter<RangeInt>
{

	public RangeIntConverter() { }

	protected virtual void ReadValue(ref RangeInt value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, RangeInt value, JsonSerializer serializer) { }

}

