namespace Newtonsoft.Json.UnityConverters.Math;

public class Matrix4x4Converter : PartialConverter<Matrix4x4>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public String[] indexes; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal IEnumerable<String> <GetMemberNames>b__0(string row) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		public string row; //Field offset: 0x10

		public <>c__DisplayClass2_1() { }

		internal string <GetMemberNames>b__1(string column) { }

	}

	private static readonly String[] _names; //Field offset: 0x0
	private static readonly Dictionary<String, Int32> _namesToIndex; //Field offset: 0x8

	private static Matrix4x4Converter() { }

	public Matrix4x4Converter() { }

	private static String[] GetMemberNames() { }

	private static Dictionary<String, Int32> GetNamesToIndex(String[] names) { }

	protected virtual void ReadValue(ref Matrix4x4 value, string name, JsonReader reader, JsonSerializer serializer) { }

	protected virtual void WriteJsonProperties(JsonWriter writer, Matrix4x4 value, JsonSerializer serializer) { }

}

