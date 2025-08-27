namespace Assets.Scripts.Utils;

[Extension]
public static class ObjectCacheExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public string dataFolder; //Field offset: 0x10
		public string fileName; //Field offset: 0x18

		public <>c__DisplayClass0_0() { }

		internal bool <Get>b__0(ObjectCache x) { }

	}


	[Extension]
	public static ObjectCache Get(List<ObjectCache> cache, string dataFolder, string fileName) { }

	[Extension]
	public static bool IsCurrent(ObjectCache objectCache, TimeSpan cacheLife) { }

}

