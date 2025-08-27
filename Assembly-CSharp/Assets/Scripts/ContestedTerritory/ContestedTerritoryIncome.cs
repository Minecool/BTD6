namespace Assets.Scripts.ContestedTerritory;

public class ContestedTerritoryIncome
{
	public int regularTilesHeld; //Field offset: 0x10
	public int regularTileIncome; //Field offset: 0x14
	public int relicTilesHeld; //Field offset: 0x18
	public int relicTileIncome; //Field offset: 0x1C
	public int bannerTilesHeld; //Field offset: 0x20
	public int bannerTileIncome; //Field offset: 0x24

	public int TotalIncome
	{
		 get { } //Length: 10
	}

	public int TotalTilesHeld
	{
		 get { } //Length: 10
	}

	public ContestedTerritoryIncome() { }

	public void AddTile(CtTileType tileType, int holdScore) { }

	public void Clear() { }

	public int get_TotalIncome() { }

	public int get_TotalTilesHeld() { }

	public static string IncomeToString(int income) { }

}

