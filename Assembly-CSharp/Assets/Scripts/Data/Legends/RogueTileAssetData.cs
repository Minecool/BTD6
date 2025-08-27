namespace Assets.Scripts.Data.Legends;

public class RogueTileAssetData
{
	public string id; //Field offset: 0x10
	public PrefabReference[] tilePrefabs; //Field offset: 0x18
	public RoguePropGroup[] propGroups; //Field offset: 0x20

	public RogueTileAssetData() { }

}

