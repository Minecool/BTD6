namespace Assets.Scripts.Data.ContestedTerritory;

public class TileData
{
	public string id; //Field offset: 0x10
	public PrefabReference tilePrefab; //Field offset: 0x18

	public string LocsKey
	{
		 get { } //Length: 42
	}

	public TileData() { }

	public string get_LocsKey() { }

}

