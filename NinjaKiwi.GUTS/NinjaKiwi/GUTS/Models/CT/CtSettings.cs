namespace NinjaKiwi.GUTS.Models.CT;

public class CtSettings
{
	[CompilerGenerated]
	private Dictionary<NodeType, ScoringSettings> <NodeTypeScoring>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <MaxGuilds>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private TicketSettings <Tickets>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <GuildMaxSize>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ScoreIncrementSettings <ScoreIncrements>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Int32[] <StartNodes>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private String[] <GuildIdBlacklist>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <RequiredForCompetitive>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private CompetitiveCtSettings <Competitive>k__BackingField; //Field offset: 0x50

	public CompetitiveCtSettings Competitive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public String[] GuildIdBlacklist
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int GuildMaxSize
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int MaxGuilds
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Dictionary<NodeType, ScoringSettings> NodeTypeScoring
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int RequiredForCompetitive
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ScoreIncrementSettings ScoreIncrements
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Int32[] StartNodes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public TicketSettings Tickets
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public CtSettings() { }

	[CompilerGenerated]
	public CompetitiveCtSettings get_Competitive() { }

	[CompilerGenerated]
	public String[] get_GuildIdBlacklist() { }

	[CompilerGenerated]
	public int get_GuildMaxSize() { }

	[CompilerGenerated]
	public int get_MaxGuilds() { }

	[CompilerGenerated]
	public Dictionary<NodeType, ScoringSettings> get_NodeTypeScoring() { }

	[CompilerGenerated]
	public int get_RequiredForCompetitive() { }

	[CompilerGenerated]
	public ScoreIncrementSettings get_ScoreIncrements() { }

	[CompilerGenerated]
	public Int32[] get_StartNodes() { }

	[CompilerGenerated]
	public TicketSettings get_Tickets() { }

	[CompilerGenerated]
	public void set_Competitive(CompetitiveCtSettings value) { }

	[CompilerGenerated]
	public void set_GuildIdBlacklist(String[] value) { }

	[CompilerGenerated]
	public void set_GuildMaxSize(int value) { }

	[CompilerGenerated]
	public void set_MaxGuilds(int value) { }

	[CompilerGenerated]
	public void set_NodeTypeScoring(Dictionary<NodeType, ScoringSettings> value) { }

	[CompilerGenerated]
	public void set_RequiredForCompetitive(int value) { }

	[CompilerGenerated]
	public void set_ScoreIncrements(ScoreIncrementSettings value) { }

	[CompilerGenerated]
	public void set_StartNodes(Int32[] value) { }

	[CompilerGenerated]
	public void set_Tickets(TicketSettings value) { }

	[OnDeserialized]
	public void ValidateBase(StreamingContext context = null) { }

}

