namespace Newtonsoft.Json.UnityConverters.Physics2D;

public class ColliderDistance2DConverter : PartialConverter<ColliderDistance2D>
{
	private static readonly FieldInfo _normalField; //Field offset: 0x0

	private static ColliderDistance2DConverter() { }

	public ColliderDistance2DConverter() { }

	protected virtual void ReadValue(ref ColliderDistance2D value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, ColliderDistance2D value, JsonSerializer serializer) { }

}

