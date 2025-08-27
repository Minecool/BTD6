namespace NinjaKiwi.GUTS.Models.Quests;

public class ActiveQuestStatus
{
	[CompilerGenerated]
	private readonly float <Progress>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <CurrentScore>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly int <TargetScore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <IsCompleted>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly Dictionary<String, Int32> <Rewards>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly String[] <RandomRewardKeys>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly bool <CanReroll>k__BackingField; //Field offset: 0x30

	public bool CanReroll
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int CurrentScore
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool IsCompleted
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public float Progress
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public String[] RandomRewardKeys
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Dictionary<String, Int32> Rewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int TargetScore
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public ActiveQuestStatus(float progress, int currentScore, int targetScore, bool isCompleted, Dictionary<String, Int32> rewards, String[] randomRewardKeys, bool canReroll) { }

	[CompilerGenerated]
	public bool get_CanReroll() { }

	[CompilerGenerated]
	public int get_CurrentScore() { }

	[CompilerGenerated]
	public bool get_IsCompleted() { }

	[CompilerGenerated]
	public float get_Progress() { }

	[CompilerGenerated]
	public String[] get_RandomRewardKeys() { }

	[CompilerGenerated]
	public Dictionary<String, Int32> get_Rewards() { }

	[CompilerGenerated]
	public int get_TargetScore() { }

}

