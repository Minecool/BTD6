namespace Assets.Scripts.Data.ContestedTerritory;

public class ExtraAssets
{
	[SerializableDictionary]
	public SerializableDictionary<BossType, PrefabReference> bossAssets; //Field offset: 0x10
	public PrefabReference shoreFoam; //Field offset: 0x18
	public PrefabReference battleDust; //Field offset: 0x20
	public PrefabReference oneTeamBattle; //Field offset: 0x28
	public PrefabReference twoTeamBattle; //Field offset: 0x30
	public PrefabReference threeTeamBattle; //Field offset: 0x38
	public PrefabReference tileShield; //Field offset: 0x40
	public PrefabReference tileMarker; //Field offset: 0x48
	public PrefabReference staleDisplay; //Field offset: 0x50
	public PlaceableAsset[] placeables; //Field offset: 0x58

	public ExtraAssets() { }

}

