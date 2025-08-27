namespace Assets.Scripts.Data.Knowledge;

public abstract class RelicKnowledgeItemBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public SubGameType subGameType; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <IsBanned>b__0(SubGameType x) { }

	}

	public ContestedTerritoryRelicType relicType; //Field offset: 0x10
	public SpriteReference icon; //Field offset: 0x18
	[Multiline]
	public string description; //Field offset: 0x20
	public bool isExternalOfGame; //Field offset: 0x28
	public List<SubGameType> bannedForGameType; //Field offset: 0x30

	public string BossRushDescriptionLocKey
	{
		 get { } //Length: 148
	}

	public string DescriptionLocKey
	{
		 get { } //Length: 148
	}

	public string Name
	{
		 get { } //Length: 83
	}

	public string NameLocKey
	{
		 get { } //Length: 129
	}

	protected RelicKnowledgeItemBase() { }

	public string get_BossRushDescriptionLocKey() { }

	public string get_DescriptionLocKey() { }

	public string get_Name() { }

	public string get_NameLocKey() { }

	public abstract KnowledgeEffect GetEffect() { }

	public bool IsBanned(SubGameType subGameType) { }

}

