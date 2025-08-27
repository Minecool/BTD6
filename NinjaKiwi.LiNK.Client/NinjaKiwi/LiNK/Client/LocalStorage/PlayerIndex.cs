namespace NinjaKiwi.LiNK.Client.LocalStorage;

internal class PlayerIndex
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DirectoryInfo, Int64> <>9__12_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal long <RegenerateIndexFile>b__12_1(DirectoryInfo di) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public long mostRecentTime; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <RegenerateIndexFile>b__2(DirectoryInfo di) { }

	}

	public readonly string CURRENT; //Field offset: 0x10
	public readonly string GUEST; //Field offset: 0x18
	public readonly string path; //Field offset: 0x20
	internal readonly Logger logger; //Field offset: 0x28
	private readonly PlayerOptions options; //Field offset: 0x30
	private readonly Dictionary<String, Guid> index; //Field offset: 0x38
	private readonly File<Dictionary`2<String, Guid>> indexFile; //Field offset: 0x40

	public int SaveCount
	{
		 get { } //Length: 61
	}

	public PlayerIndex(string environment, string storageRootPath, PlayerOptions playerOptions) { }

	[CompilerGenerated]
	private bool <RegenerateIndexFile>b__12_0(DirectoryInfo di) { }

	public void Delete() { }

	private bool DirectoryContainsSave(DirectoryInfo directoryInfo) { }

	public int get_SaveCount() { }

	public Guid GetFileID(string key) { }

	private File<Dictionary`2<String, Guid>> RegenerateIndexFile(string storageRootPath, string indexFilePath, JsonSerializerSettings jsonSettings, Strategy storageStrategy) { }

}

