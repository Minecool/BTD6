namespace Assets.Scripts.Models.ServerEvents;

public class ContestedTerritorySettings : EnableFlag
{
	public Int32[] checkpointCosts; //Field offset: 0x18
	public TimeSpan refreshTimeOut; //Field offset: 0x20
	public TimeSpan tileUpdateTimeOut; //Field offset: 0x28
	public TimeSpan tileUpdateIngameInterval; //Field offset: 0x30
	public TimeSpan ticketRequestTimeOut; //Field offset: 0x38
	public CtActivitySettings activity; //Field offset: 0x40
	public TimeSpan relicVoteTimeOut; //Field offset: 0x48
	public TimeSpan trophyContributionTimeout; //Field offset: 0x50
	public EventRelicSettings eventRelics; //Field offset: 0x58
	public bool reportTileStart; //Field offset: 0x60
	public int maxTileMarkers; //Field offset: 0x64
	public int maxParagons; //Field offset: 0x68

	public ContestedTerritorySettings() { }

}

