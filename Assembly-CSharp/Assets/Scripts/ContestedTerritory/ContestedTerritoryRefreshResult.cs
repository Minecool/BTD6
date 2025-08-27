namespace Assets.Scripts.ContestedTerritory;

public class ContestedTerritoryRefreshResult
{
	public readonly IReadOnlyCollection<Int32> newTeams; //Field offset: 0x10
	public readonly IReadOnlyCollection<Int32> newCapturedTiles; //Field offset: 0x18
	public readonly IReadOnlyCollection<Int32> newExpiredTiles; //Field offset: 0x20
	public readonly Nullable<Int32> lastTilePlayed; //Field offset: 0x28
	public readonly bool lastTilePlayedWasCaptured; //Field offset: 0x30

	public ContestedTerritoryRefreshResult(IEnumerable<Int32> newTeams, IEnumerable<Int32> newCapturedTiles, IEnumerable<Int32> newExpiredTiles, Nullable<Int32> lastTilePlayed, bool lastTilePlayedWasCaptured) { }

	public bool HasChanges() { }

}

