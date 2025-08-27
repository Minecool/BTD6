namespace Assets.Scripts.Data.Knowledge;

public class ActiveKnowledge
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string knowledgeId; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <Get>b__0(KnowledgeModel x) { }

		internal bool <Get>b__1(KnowledgeModel k) { }

	}

	public const int LatestVersion = 0; //Field offset: 0x0
	public ushort version; //Field offset: 0x10
	public UInt64[] masks; //Field offset: 0x18

	public static ActiveKnowledge NoKnowledge
	{
		 get { } //Length: 114
	}

	public ActiveKnowledge() { }

	public ActiveKnowledge Clone() { }

	public static ActiveKnowledge Get(HashSet<String> knowledges, GameModel gm = null) { }

	public static HashSet<String> Get(ActiveKnowledge knowledges, GameModel gm = null) { }

	public static ActiveKnowledge get_NoKnowledge() { }

}

