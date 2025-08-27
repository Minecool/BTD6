namespace Assets.Scripts.Utils.Leaderboards;

public class MetadataBuilder
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, String>, String> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToString>b__13_0(KeyValuePair<String, String> kvp) { }

	}

	public const char kMetadataSeparator = '\u3B'; //Field offset: 0x0
	public const char kKvpSeparator = '\u2C'; //Field offset: 0x0
	private readonly Dictionary<String, String> metadatas; //Field offset: 0x10
	private string cachedMetadata; //Field offset: 0x18

	public MetadataBuilder() { }

	public MetadataBuilder(string source) { }

	public MetadataBuilder Clone() { }

	public string Get(string key) { }

	public void Parse(string source) { }

	public void Set(string key, string value) { }

	public void Set(string key, int value) { }

	public virtual string ToString() { }

	public bool TryGetInt(string key, out int value) { }

	public bool TryGetLong(string key, out long value) { }

	public bool TryGetString(string key, out string value) { }

}

