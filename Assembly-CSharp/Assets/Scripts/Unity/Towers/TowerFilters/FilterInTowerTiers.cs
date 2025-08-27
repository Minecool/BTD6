namespace Assets.Scripts.Unity.Towers.TowerFilters;

public class FilterInTowerTiers : TowerFilter
{
	public FilterInTowerTiers parent; //Field offset: 0x88
	public int path1MinTier; //Field offset: 0x90
	public string expPath1MinTier; //Field offset: 0x98
	public int path1MaxTier; //Field offset: 0xA0
	public string expPath1MaxTier; //Field offset: 0xA8
	public int path2MinTier; //Field offset: 0xB0
	public string expPath2MinTier; //Field offset: 0xB8
	public int path2MaxTier; //Field offset: 0xC0
	public string expPath2MaxTier; //Field offset: 0xC8
	public int path3MinTier; //Field offset: 0xD0
	public string expPath3MinTier; //Field offset: 0xD8
	public int path3MaxTier; //Field offset: 0xE0
	public string expPath3MaxTier; //Field offset: 0xE8

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 191
	}

	public FilterInTowerTiers() { }

	public virtual TowerFilterModel get_Def() { }

}

