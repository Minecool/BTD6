namespace Newtonsoft.Json.UnityConverters.Camera;

public class CullingGroupEventConverter : PartialConverter<CullingGroupEvent>
{
	private const byte DISTANCE_MASK = 127; //Field offset: 0x0
	[MaybeNull]
	private static readonly FieldInfo _indexField; //Field offset: 0x0
	[MaybeNull]
	private static readonly FieldInfo _prevStateField; //Field offset: 0x8
	[MaybeNull]
	private static readonly FieldInfo _thisStateField; //Field offset: 0x10

	private static CullingGroupEventConverter() { }

	public CullingGroupEventConverter() { }

	protected virtual void ReadValue(ref CullingGroupEvent value, string name, JsonReader reader, JsonSerializer serializer) { }

	private static void SetStateField(FieldInfo field, ref CullingGroupEvent value, int distance, bool isVisible) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, CullingGroupEvent value, JsonSerializer serializer) { }

}

