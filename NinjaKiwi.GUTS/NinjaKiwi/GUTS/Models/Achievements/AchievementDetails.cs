namespace NinjaKiwi.GUTS.Models.Achievements;

public class AchievementDetails
{
	[CompilerGenerated]
	private String[] <StatKeys>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <RequiredScore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary<String, Dictionary`2<String, Int32>> <Rewards>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private String[] <BankItemRewards>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <DisplayScreen>k__BackingField; //Field offset: 0x30

	public String[] BankItemRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string DisplayScreen
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int RequiredScore
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Dictionary<String, Dictionary`2<String, Int32>> Rewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public String[] StatKeys
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public AchievementDetails() { }

	public bool CanShowOnScreen(string screenName) { }

	[CompilerGenerated]
	public String[] get_BankItemRewards() { }

	[CompilerGenerated]
	public string get_DisplayScreen() { }

	[CompilerGenerated]
	public int get_RequiredScore() { }

	[CompilerGenerated]
	public Dictionary<String, Dictionary`2<String, Int32>> get_Rewards() { }

	[CompilerGenerated]
	public String[] get_StatKeys() { }

	public bool HasRewards() { }

	[CompilerGenerated]
	public void set_BankItemRewards(String[] value) { }

	[CompilerGenerated]
	public void set_DisplayScreen(string value) { }

	[CompilerGenerated]
	public void set_RequiredScore(int value) { }

	[CompilerGenerated]
	public void set_Rewards(Dictionary<String, Dictionary`2<String, Int32>> value) { }

	[CompilerGenerated]
	public void set_StatKeys(String[] value) { }

}

