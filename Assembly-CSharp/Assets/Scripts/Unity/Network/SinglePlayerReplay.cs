namespace Assets.Scripts.Unity.Network;

public class SinglePlayerReplay : Replay
{
	[CompilerGenerated]
	private readonly string <map>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <difficulty>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly string <mode>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private readonly string <hero>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly bool <doubleCash>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly bool <goldenBloonActive>k__BackingField; //Field offset: 0x49
	[CompilerGenerated]
	private readonly ActiveKnowledge <knowledge>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly ActiveRelicKnowledge <relicKnowledge>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly BossGameData <bossData>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly QuestGameData <questData>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly bool <fastTrack>k__BackingField; //Field offset: 0x70

	public BossGameData bossData
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string difficulty
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool doubleCash
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool fastTrack
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool goldenBloonActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string hero
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ActiveKnowledge knowledge
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string map
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string mode
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public QuestGameData questData
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ActiveRelicKnowledge relicKnowledge
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public SinglePlayerReplay(int randomSeed, string map, string difficulty, string mode, string hero, bool doubleCash, bool goldenBloonActive, ActiveKnowledge knowledge, ActiveRelicKnowledge relicKnowledge, BossGameData bossData, QuestGameData questData, bool fastTrack) { }

	[CompilerGenerated]
	public BossGameData get_bossData() { }

	[CompilerGenerated]
	public string get_difficulty() { }

	[CompilerGenerated]
	public bool get_doubleCash() { }

	[CompilerGenerated]
	public bool get_fastTrack() { }

	[CompilerGenerated]
	public bool get_goldenBloonActive() { }

	[CompilerGenerated]
	public string get_hero() { }

	[CompilerGenerated]
	public ActiveKnowledge get_knowledge() { }

	[CompilerGenerated]
	public string get_map() { }

	[CompilerGenerated]
	public string get_mode() { }

	[CompilerGenerated]
	public QuestGameData get_questData() { }

	[CompilerGenerated]
	public ActiveRelicKnowledge get_relicKnowledge() { }

	public virtual string Serialize() { }

}

