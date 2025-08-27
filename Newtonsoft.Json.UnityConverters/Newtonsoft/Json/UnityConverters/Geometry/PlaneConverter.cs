namespace Newtonsoft.Json.UnityConverters.Geometry;

public class PlaneConverter : PartialConverter<Plane>
{

	public PlaneConverter() { }

	protected virtual void ReadValue(ref Plane value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Plane value, JsonSerializer serializer) { }

}

