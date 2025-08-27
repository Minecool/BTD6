namespace Newtonsoft.Json.UnityConverters.Utility;

internal static class TypeCache
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal NamedAssembly <.cctor>b__3_0(Assembly x) { }

		internal bool <.cctor>b__3_1(NamedAssembly x) { }

		internal string <.cctor>b__3_2(NamedAssembly x) { }

	}

	[IsReadOnly]
	private struct NamedAssembly
	{
		[CompilerGenerated]
		private readonly Assembly <assembly>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly string <name>k__BackingField; //Field offset: 0x8

		public Assembly assembly
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public string name
		{
			[CompilerGenerated]
			 get { } //Length: 291
		}

		public NamedAssembly(Assembly assembly) { }

		[CompilerGenerated]
		public Assembly get_assembly() { }

		[CompilerGenerated]
		public string get_name() { }

	}

	private static readonly Dictionary<ValueTuple`2<String, String>, Type> _typeByNameAndAssembly; //Field offset: 0x0
	private static readonly Dictionary<String, Assembly> _assemblyByName; //Field offset: 0x8
	private static readonly Assembly[] _assemblies; //Field offset: 0x10

	private static TypeCache() { }

	private static int AssemblyOrderBy(NamedAssembly record) { }

	public static Type FindType(string name, string assemblyName) { }

	private static string GetRootNamespace(string name) { }

}

