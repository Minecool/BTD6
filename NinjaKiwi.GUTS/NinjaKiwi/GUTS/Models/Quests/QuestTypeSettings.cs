namespace NinjaKiwi.GUTS.Models.Quests;

public class QuestTypeSettings
{
	[CompilerGenerated]
	private Dictionary<String, QuestDetails> <Quests>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Slots>k__BackingField; //Field offset: 0x18

	[JsonIgnore]
	public bool HasQuests
	{
		 get { } //Length: 83
	}

	public Dictionary<String, QuestDetails> Quests
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int Slots
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public QuestTypeSettings() { }

	public bool get_HasQuests() { }

	[CompilerGenerated]
	public Dictionary<String, QuestDetails> get_Quests() { }

	[CompilerGenerated]
	public int get_Slots() { }

	[CompilerGenerated]
	public void set_Quests(Dictionary<String, QuestDetails> value) { }

	[CompilerGenerated]
	public void set_Slots(int value) { }

}

