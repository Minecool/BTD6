namespace Assets.Scripts.ContestedTerritory.Api;

public class TeamStoreRelic
{
	public readonly ContestedTerritoryRelicType relicType; //Field offset: 0x10
	public readonly Nullable<DateTime> expiresAt; //Field offset: 0x18
	public readonly Nullable<DateTime> unlocksAt; //Field offset: 0x28
	public readonly TeamStoreItemContributions contributions; //Field offset: 0x38
	public readonly string contributionId; //Field offset: 0x40

	public bool IsAvailable
	{
		 get { } //Length: 297
	}

	public TeamStoreRelic(ContestedTerritoryRelicType relicType, Nullable<DateTime> expiresAt, Nullable<DateTime> unlocksAt, TeamStoreItemContributions contributions, string contributionId) { }

	public bool get_IsAvailable() { }

}

