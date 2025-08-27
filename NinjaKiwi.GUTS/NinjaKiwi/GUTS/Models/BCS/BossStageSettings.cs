namespace NinjaKiwi.GUTS.Models.BCS;

[Nullable(0)]
[NullableContext(2)]
public class BossStageSettings
{
	[CompilerGenerated]
	private string <BossId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <CompletionScore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private Dictionary<Int32, String[]> <SkullEffects>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private String[] <MatchEffects>k__BackingField; //Field offset: 0x28

	public string BossId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int CompletionScore
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public String[] MatchEffects
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	public Dictionary<Int32, String[]> SkullEffects
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BossStageSettings() { }

	[CompilerGenerated]
	public string get_BossId() { }

	[CompilerGenerated]
	public int get_CompletionScore() { }

	[CompilerGenerated]
	public String[] get_MatchEffects() { }

	[CompilerGenerated]
	public Dictionary<Int32, String[]> get_SkullEffects() { }

	[CompilerGenerated]
	public void set_BossId(string value) { }

	[CompilerGenerated]
	public void set_CompletionScore(int value) { }

	[CompilerGenerated]
	public void set_MatchEffects(String[] value) { }

	[CompilerGenerated]
	public void set_SkullEffects(Dictionary<Int32, String[]> value) { }

}

