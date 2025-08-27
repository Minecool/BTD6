namespace NinjaKiwi.GUTS.Utils.ElasticSearch;

public class PainlessScript
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Int32> <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetParametersFromSource>b__4_0(string x) { }

	}

	public readonly string lang; //Field offset: 0x10
	public readonly string source; //Field offset: 0x18
	[JsonProperty("params")]
	public readonly Dictionary<String, Object> parameters; //Field offset: 0x20

	public PainlessScript(string source) { }

	private List<Tuple`3<String, Int32, Object>> GetParametersFromSource(string source) { }

	private static string ReplaceParametersInSource(string source, List<Tuple`3<String, Int32, Object>> parameters) { }

}

