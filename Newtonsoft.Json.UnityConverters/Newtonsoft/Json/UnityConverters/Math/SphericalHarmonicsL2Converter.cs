namespace Newtonsoft.Json.UnityConverters.Math;

public class SphericalHarmonicsL2Converter : PartialConverter<SphericalHarmonicsL2>
{
	private const int COEFFICIENT_COUNT = 9; //Field offset: 0x0
	private const int ARRAY_SIZE = 27; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"name", "rgb", "coefficient"}])]
	private static readonly ValueTuple<String, Int32, Int32>[] _indices; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"color", "coefficient"}])]
	private static readonly Dictionary<String, ValueTuple`2<Int32, Int32>> _nameToIndex; //Field offset: 0x8

	private static SphericalHarmonicsL2Converter() { }

	public SphericalHarmonicsL2Converter() { }

	private static ValueTuple<String, Int32, Int32>[] GetMemberNames() { }

	private static Dictionary<String, ValueTuple`2<Int32, Int32>> GetNamesToIndexDictionary(ValueTuple<String, Int32, Int32>[] indices) { }

	protected virtual void ReadValue(ref SphericalHarmonicsL2 value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, SphericalHarmonicsL2 value, JsonSerializer serializer) { }

}

