namespace NinjaKiwi.GUTS.Models.BCS;

[Nullable(0)]
[NullableContext(2)]
public class BossSettings
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Dictionary<Int32, BossStageSettings> <Stages>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Dictionary<String, Int32> <CardLimits>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private String[] <BannedCards>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <BossName>k__BackingField; //Field offset: 0x28

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public String[] BannedCards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string BossName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public Dictionary<String, Int32> CardLimits
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public Dictionary<Int32, BossStageSettings> Stages
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BossSettings() { }

	[CompilerGenerated]
	public String[] get_BannedCards() { }

	[CompilerGenerated]
	public string get_BossName() { }

	[CompilerGenerated]
	public Dictionary<String, Int32> get_CardLimits() { }

	[CompilerGenerated]
	public Dictionary<Int32, BossStageSettings> get_Stages() { }

	public IEnumerable<KeyValuePair`2<String, String>> GetItemIdReplacements() { }

	[CompilerGenerated]
	public void set_BannedCards(String[] value) { }

	[CompilerGenerated]
	public void set_BossName(string value) { }

	[CompilerGenerated]
	public void set_CardLimits(Dictionary<String, Int32> value) { }

	[CompilerGenerated]
	public void set_Stages(Dictionary<Int32, BossStageSettings> value) { }

}

