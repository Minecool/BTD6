namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class SetScoreResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private bool <IsNodeCaptured>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private NodeStatus <NodeStatus>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private NodeStatus <PreviousNodeStatus>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsScoreSubmitted>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <ScoreToBeat>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private bool <WasGuildTicket>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsCompetitive>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	private Nullable<Int64> <Ts>k__BackingField; //Field offset: 0x40

	public bool IsCompetitive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsNodeCaptured
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsScoreSubmitted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 86
	}

	[JsonIgnore]
	public bool IsTicketConsumed
	{
		 get { } //Length: 5
	}

	public NodeStatus NodeStatus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public NodeStatus PreviousNodeStatus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int ScoreToBeat
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public Nullable<Int64> Ts
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool WasGuildTicket
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public SetScoreResponse() { }

	[CompilerGenerated]
	public bool get_IsCompetitive() { }

	[CompilerGenerated]
	public bool get_IsNodeCaptured() { }

	[CompilerGenerated]
	public bool get_IsScoreSubmitted() { }

	public bool get_IsTicketConsumed() { }

	[CompilerGenerated]
	public NodeStatus get_NodeStatus() { }

	[CompilerGenerated]
	public NodeStatus get_PreviousNodeStatus() { }

	[CompilerGenerated]
	public int get_ScoreToBeat() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public Nullable<Int64> get_Ts() { }

	[CompilerGenerated]
	public bool get_WasGuildTicket() { }

	[CompilerGenerated]
	public void set_IsCompetitive(bool value) { }

	[CompilerGenerated]
	public void set_IsNodeCaptured(bool value) { }

	[CompilerGenerated]
	public void set_IsScoreSubmitted(bool value) { }

	[CompilerGenerated]
	public void set_NodeStatus(NodeStatus value) { }

	[CompilerGenerated]
	public void set_PreviousNodeStatus(NodeStatus value) { }

	[CompilerGenerated]
	public void set_ScoreToBeat(int value) { }

	[CompilerGenerated]
	public void set_Ts(Nullable<Int64> value) { }

	[CompilerGenerated]
	public void set_WasGuildTicket(bool value) { }

}

