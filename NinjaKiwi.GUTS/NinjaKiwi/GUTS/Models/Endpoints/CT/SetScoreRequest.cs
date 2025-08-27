namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class SetScoreRequest : BaseSignedInRequest
{
	[CompilerGenerated]
	private int <NodeId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <Score>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private string <PlayerMetadata>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <GuildMetadata>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <Misc>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <GameId>k__BackingField; //Field offset: 0x40

	public int GameId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string GuildMetadata
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string Misc
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[ValidRange(0, 2147483647)]
	public int NodeId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string PlayerMetadata
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[ValidRange(1, 2147483647)]
	public int Score
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public SetScoreRequest() { }

	[CompilerGenerated]
	public int get_GameId() { }

	[CompilerGenerated]
	public string get_GuildMetadata() { }

	[CompilerGenerated]
	public string get_Misc() { }

	[CompilerGenerated]
	public int get_NodeId() { }

	[CompilerGenerated]
	public string get_PlayerMetadata() { }

	[CompilerGenerated]
	public int get_Score() { }

	[CompilerGenerated]
	public void set_GameId(int value) { }

	[CompilerGenerated]
	public void set_GuildMetadata(string value) { }

	[CompilerGenerated]
	public void set_Misc(string value) { }

	[CompilerGenerated]
	public void set_NodeId(int value) { }

	[CompilerGenerated]
	public void set_PlayerMetadata(string value) { }

	[CompilerGenerated]
	public void set_Score(int value) { }

}

