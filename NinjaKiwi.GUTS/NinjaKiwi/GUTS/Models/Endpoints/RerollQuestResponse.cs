namespace NinjaKiwi.GUTS.Models.Endpoints;

public class RerollQuestResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private ActiveQuests <PlayerQuests>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ActiveQuest <NewQuest>k__BackingField; //Field offset: 0x20

	public ActiveQuest NewQuest
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ActiveQuests PlayerQuests
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 26
	}

	public RerollQuestResponse() { }

	[CompilerGenerated]
	public ActiveQuest get_NewQuest() { }

	[CompilerGenerated]
	public ActiveQuests get_PlayerQuests() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_NewQuest(ActiveQuest value) { }

	[CompilerGenerated]
	public void set_PlayerQuests(ActiveQuests value) { }

}

