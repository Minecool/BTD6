namespace Newtonsoft.Json.UnityConverters.Random;

public class RandomStateConverter : PartialConverter<State>
{
	private static readonly FieldInfo _s0Field; //Field offset: 0x0
	private static readonly FieldInfo _s1Field; //Field offset: 0x8
	private static readonly FieldInfo _s2Field; //Field offset: 0x10
	private static readonly FieldInfo _s3Field; //Field offset: 0x18

	private static RandomStateConverter() { }

	public RandomStateConverter() { }

	protected virtual void ReadValue(ref State value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, State value, JsonSerializer serializer) { }

}

